using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Driver;

namespace ServerSideAnalytics.Mongo
{
    public class MongoAnalyticStore : IAnalyticStore
    {
        private static readonly IMapper Mapper;

        private readonly MongoUrl _url;
        private IMongoCollection<MongoWebRequest> _requestCollection;
        private IMongoCollection<MongoGeoIpRange> _geoIpCollection;

        static MongoAnalyticStore()
        {
             var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<WebRequest, MongoWebRequest>()
                     .ForMember(dest => dest.RemoteIpAddress, x => x.MapFrom(req => req.RemoteIpAddress.ToString()));

                 cfg.CreateMap<MongoWebRequest, WebRequest>()
                     .ForMember(dest => dest.RemoteIpAddress, x => x.MapFrom(req => IPAddress.Parse(req.RemoteIpAddress)));
             });

            Mapper = config.CreateMapper();
        }

        public MongoAnalyticStore() : this("mongodb://localhost/default")
        {
        }

        public MongoAnalyticStore(string connectionString)
        {
            _url = new MongoUrl(connectionString);
            RequestCollection("SSARequest");
            GeoIpCollection("SSAGeoIP");
        }

        public MongoAnalyticStore RequestCollection(string tableName)
        {
            var client = new MongoClient(_url);
            _requestCollection = client.GetDatabase(_url.DatabaseName ?? "default")
                .GetCollection<MongoWebRequest>(tableName);

            var builder = Builders<MongoWebRequest>.IndexKeys;

            _requestCollection.Indexes.CreateOne(new CreateIndexModel<MongoWebRequest>(builder.Ascending(x => x.CountryCode)));
            _requestCollection.Indexes.CreateOne(new CreateIndexModel<MongoWebRequest>(builder.Ascending(x => x.Identity)));
            _requestCollection.Indexes.CreateOne(new CreateIndexModel<MongoWebRequest>(builder.Ascending(x => x.Path)));
            _requestCollection.Indexes.CreateOne(new CreateIndexModel<MongoWebRequest>(builder.Ascending(x => x.RemoteIpAddress)));
            _requestCollection.Indexes.CreateOne(new CreateIndexModel<MongoWebRequest>(builder.Ascending(x => x.UserAgent)));

            return this;
        }

        public MongoAnalyticStore GeoIpCollection(string tableName)
        {
            var client = new MongoClient(_url);
            _geoIpCollection = client.GetDatabase(_url.DatabaseName ?? "default")
                .GetCollection<MongoGeoIpRange>(tableName);
            return this;
        }

        public Task StoreWebRequestAsync(WebRequest request)
        {
            return _requestCollection.InsertOneAsync(Mapper.Map<MongoWebRequest>(request));
        }

        public Task<long> CountUniqueIdentitiesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return CountUniqueIdentitiesAsync(from, to);
        }

        public async Task<long> CountUniqueIdentitiesAsync(DateTime from, DateTime to)
        {
            return (await UniqueIdentitiesAsync(from, to)).LongCount();
        }

        public Task<IEnumerable<string>> UniqueIdentitiesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return UniqueIdentitiesAsync(from, to);
        }

        public async Task<IEnumerable<string>> UniqueIdentitiesAsync(DateTime @from, DateTime to)
        {
            var identities = await _requestCollection.DistinctAsync(x => x.Identity, x => x.Timestamp >= from && x.Timestamp <= to);
            return identities.ToEnumerable();
        }

        public Task<long> CountAsync(DateTime from, DateTime to)
        {
            return _requestCollection.CountDocumentsAsync(x => x.Timestamp >= from && x.Timestamp <= to);
        }

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return IpAddressesAsync(from, to);
        }

        public async Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime from, DateTime to)
        {
            var ips = await _requestCollection.DistinctAsync(x => x.RemoteIpAddress, x => x.Timestamp >= from && x.Timestamp <= to);
            return ips.ToEnumerable()
                .Select(IPAddress.Parse)
                .ToArray();
        }

        public async Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity)
        {
            var identities = await _requestCollection.FindAsync(x => x.Identity == identity);
            return identities.ToEnumerable().Select( x => Mapper.Map<WebRequest>(x));
        }

        public Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            return _geoIpCollection.InsertOneAsync(new MongoGeoIpRange
            {
                From = from.ToFullDecimalString(),
                To = to.ToFullDecimalString(),
                CountryCode = countryCode
            });
        }

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            var addressString = address.ToFullDecimalString();

            var filter = Builders<MongoGeoIpRange>.Filter.Lte(x => x.From, addressString)
                         & Builders<MongoGeoIpRange>.Filter.Gte(x => x.To, addressString);

            var found = await _geoIpCollection.FindAsync(filter);
            return (await found.FirstOrDefaultAsync())?.CountryCode ?? CountryCode.World;
        }

        public Task PurgeRequestAsync() => _requestCollection.DeleteManyAsync(x => true);

        public Task PurgeGeoIpAsync() => _geoIpCollection.DeleteManyAsync(x => true);

        public async Task<IEnumerable<WebRequest>> InTimeRange(DateTime from, DateTime to)
        {
            return (await (await _requestCollection
                .FindAsync(x => x.Timestamp >= from && x.Timestamp <= to)).ToListAsync())
                .Select(x => Mapper.Map<WebRequest>(x))
                .ToList();
        }
    }
}