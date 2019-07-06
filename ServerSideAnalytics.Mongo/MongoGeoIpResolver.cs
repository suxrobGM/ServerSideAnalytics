using MongoDB.Driver;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Mongo
{
    public class MongoGeoIpResolver : IGeoIpResolver
    {
        private readonly MongoUrl _url;
        private IMongoCollection<MongoGeoIpRange> _geoIpCollection;

        public MongoGeoIpResolver() : this("mongodb://localhost/default")
        {
        }

        public MongoGeoIpResolver(string connectionString)
        {
            _url = new MongoUrl(connectionString);
            GeoIpCollection("SSAGeoIP");
        }

        public IGeoIpResolver GeoIpCollection(string tableName)
        {
            var client = new MongoClient(_url);
            _geoIpCollection = client.GetDatabase(_url.DatabaseName ?? "default")
                .GetCollection<MongoGeoIpRange>(tableName);
            return this;
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


        public Task PurgeGeoIpAsync() => _geoIpCollection.DeleteManyAsync(x => true);
    }
}
