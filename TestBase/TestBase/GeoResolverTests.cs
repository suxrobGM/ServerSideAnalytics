using ServerSideAnalytics;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace TestBase
{
    class GeoResolverTests
    {

        public static async Task TestGeoResolve(IGeoIpResolver store)
        {
            await store.StoreGeoIpRangeAsync(IPAddress.Parse("86.44.0.0"), IPAddress.Parse("86.49.47.255"),
                CountryCode.Cz);

            await store.StoreGeoIpRangeAsync(IPAddress.Parse("85.44.0.0"), IPAddress.Parse("86.43.255.255"),
                CountryCode.Sk);

            await store.StoreGeoIpRangeAsync(IPAddress.Parse("86.49.48.0"), IPAddress.Parse("86.86.255.255"),
                CountryCode.It);

            Assert.Equal(CountryCode.Cz, await store.ResolveCountryCodeAsync(IPAddress.Parse("86.49.47.89")));
        }
    }
}
