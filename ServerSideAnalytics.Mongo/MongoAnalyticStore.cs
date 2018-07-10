using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Maddalena;
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

        public MongoAnalyticStore RequestCollection(string tablename)
        {
            var client = new MongoClient(_url);
            _requestCollection = client.GetDatabase(_url.DatabaseName ?? "default")
                .GetCollection<MongoWebRequest>(tablename);

            return this;
        }

        public MongoAnalyticStore GeoIpCollection(string tablename)
        {
            var client = new MongoClient(_url);
            _geoIpCollection = client.GetDatabase(_url.DatabaseName ?? "default")
                .GetCollection<MongoGeoIpRange>(tablename);
            return this;
        }

        public Task StoreWebRequestAsync(WebRequest request)
        {
            return _requestCollection.InsertOneAsync(Mapper.Map<MongoWebRequest>(request));
        }

        public Task<long> CountUniqueIndentitiesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return CountUniqueIndentitiesAsync(from, to);
        }

        public async Task<long> CountUniqueIndentitiesAsync(DateTime from, DateTime to)
        {
            var identities = await _requestCollection.DistinctAsync(x => x.Identity, x => x.Timestamp >= from && x.Timestamp <= to);
            return identities.ToEnumerable().Count();
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
            //Convert both items into bytes
            var bytesFrom = from.GetAddressBytes();
            var bytesTo = to.GetAddressBytes();

            //Force IPV6 by adding empty bytes if missing
            Array.Resize(ref bytesFrom, 16);
            Array.Resize(ref bytesTo, 16);

            //Every limit of the range is splitted in two
            //Up and Down, both Int64 that togheter creates an Int128
            
            return _geoIpCollection.InsertOneAsync(new MongoGeoIpRange
            {
                FromDown = BitConverter.ToInt64(bytesFrom,0),
                FromUp = BitConverter.ToInt64(bytesFrom,8),

                ToDown = BitConverter.ToInt64(bytesTo,0),
                ToUp = BitConverter.ToInt64(bytesTo,8),
                CountryCode = countryCode
            });
        }

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            //Getting address bytes
            var bytes = address.GetAddressBytes();

            //Normalizing to IPV6 filling with empty bytes if missing
            Array.Resize(ref bytes, 16);

            //Convert bytes to two Int64 (to form an Int128)
            var down = BitConverter.ToInt64(bytes, 0);
            var up = BitConverter.ToInt64(bytes, 8);

            // Making query
            // Sadly quering separatly the two components of the Int128
            // (Up and Down)
            var found = await _geoIpCollection.FindAsync(x => x.FromDown <= down && x.ToDown >= down && x.FromUp <= up && x.ToUp >= up);
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