using ServerSideAnalytics;
using ServerSideAnalytics.GeoLite;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace TestGeoLite
{
    public class GeoLiteTest
    {
        [Fact]
        public async Task TestGeoLite()
        {
            var geo = new MaxMindGeoIpResolver("GeoLite2-Country.mmdb");
            var cz = await geo.ResolveCountryCodeAsync(IPAddress.Parse("62.24.69.224"));

            Assert.Equal(CountryCode.Cz, cz);
        }
    }
}
