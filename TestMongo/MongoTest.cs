using System;
using System.Threading.Tasks;
using ServerSideAnalytics.Mongo;
using Xunit;

namespace TestMongo
{
    public class MongoTest
    {
        [Fact]
        public async Task TestMongo()
        {
            await TestBase.StoreTests.RunAll(async () =>
            {
                var db = new MongoAnalyticStore();
                await db.PurgeRequestAsync();
                return db;
            },
            async ()=> 
            {
                var db = new MongoGeoIpResolver();
                await db.PurgeGeoIpAsync();
                return db;
            });
        }
    }
}
