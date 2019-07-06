using System;
using System.Threading.Tasks;
using ServerSideAnalytics.SqlServer;
using Xunit;

namespace TestSqlServer
{
    public class SqlServerTest
    {
        const string connectionString = "Server=localhost;Database=test;Trusted_Connection=True";

        [Fact]
        public async Task TestSqlServerAsync()
        {
            await TestBase.StoreTests.RunAll(async () =>
            {
                var db = new SqlServerAnalyticStore(connectionString);
                await db.PurgeRequestAsync();
                return db;
            },
            async () =>
            {
                var db = new SqlServerGeoIpResolver(connectionString);
                await db.PurgeGeoIpAsync();
                return db;
            });
        }
    }
}
