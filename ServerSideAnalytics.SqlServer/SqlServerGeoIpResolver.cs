using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.SqlServer
{
    public class SqlServerGeoIpResolver : IGeoIpResolver
    {
        private readonly string _connectionString;
        private string _geoIpTable = "SSAGeoIP";

        private SqlServerGeoIpContext GetContext()
        {
            var db = new SqlServerGeoIpContext(_connectionString, _geoIpTable);
            db.Database.EnsureCreated();
            return db;
        }

        public SqlServerGeoIpResolver(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlServerGeoIpResolver GeoIpTable(string tablename)
        {
            _geoIpTable = tablename;
            return this;
        }

        public async Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            var bytesFrom = from.GetAddressBytes();
            var bytesTo = to.GetAddressBytes();

            Array.Resize(ref bytesFrom, 16);
            Array.Resize(ref bytesTo, 16);

            using (var db = GetContext())
            {
                await db.GeoIpRange.AddAsync(new SqlServerGeoIpRange
                {
                    From = from.ToFullDecimalString(),
                    To = to.ToFullDecimalString(),
                    CountryCode = countryCode
                });
                await db.SaveChangesAsync();
            }
        }

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            var addressString = address.ToFullDecimalString();

            using (var db = GetContext())
            {
                var found = await db.GeoIpRange.FirstOrDefaultAsync(x => x.From.CompareTo(addressString) <= 0 &&
                                                                         x.To.CompareTo(addressString) >= 0);

                return found?.CountryCode ?? CountryCode.World;
            }
        }


        public async Task PurgeGeoIpAsync()
        {
            using (var db = GetContext())
            {
                await db.Database.EnsureCreatedAsync();
                db.GeoIpRange.RemoveRange(db.GeoIpRange);
                await db.SaveChangesAsync();
            }
        }
    }
}
