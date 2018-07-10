using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ServerSideAnalytics;
using Xunit;
using WebRequest = ServerSideAnalytics.WebRequest;

namespace TestBase
{
    public static class StoreTests
    {
        public static WebRequest[] MatteoRequests = (new []{ "/", "/home", "/read", "/", "/stat"}).Select(path =>
        new WebRequest
        {
            RemoteIpAddress = IPAddress.Parse("86.49.47.89"),
            CountryCode = CountryCode.CZ,
            Path = "/",
            Identity = "MATTEO",
            IsWebSocket = false,
            Method = "GET",
            Referer = "",
            Timestamp = DateTime.Now,
            UserAgent = "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)"
        }).ToArray();

        public static WebRequest[] FrancoRequests = (new[] { "/", "/home", "/read", "/", "/stat" }).Select(path =>
            new WebRequest
            {
                RemoteIpAddress = IPAddress.Parse("212.95.74.42"),
                CountryCode = CountryCode.FR,
                Path = "/",
                Identity = "FRANCO",
                IsWebSocket = false,
                Method = "GET",
                Referer = "",
                Timestamp = DateTime.Now,
                UserAgent = "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)"
            }).ToArray();


        public static async Task RunAll(Func<Task<IAnalyticStore>> getNewStore)
        {
            await TestStorage(await getNewStore());
            await TestCount(await getNewStore());
            await TestCountIdentities(await getNewStore());
            await TestIpAddress(await getNewStore());
            await TestRequestByIdentity(await getNewStore());
            await TestGeoResolve(await getNewStore());
        }

        public static async Task TestStorage(IAnalyticStore store)
        {
            await store.StoreWebRequestAsync(MatteoRequests[0]);
        }

        public static async Task TestCount(IAnalyticStore store)
        {
            foreach (var request in MatteoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            Assert.Equal(MatteoRequests.Length, await store.CountAsync(DateTime.MinValue, DateTime.MaxValue));
        }

        public static async Task TestCountIdentities(IAnalyticStore store)
        {
            foreach (var request in MatteoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            Assert.Equal(1, await store.CountUniqueIndentitiesAsync(DateTime.Today));
            Assert.Equal(1, await store.CountUniqueIndentitiesAsync(DateTime.MinValue, DateTime.MaxValue));

            foreach (var request in FrancoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            Assert.Equal(2, await store.CountUniqueIndentitiesAsync(DateTime.Today));
            Assert.Equal(2, await store.CountUniqueIndentitiesAsync(DateTime.MinValue, DateTime.MaxValue));
        }

        public static async Task TestIpAddress(IAnalyticStore store)
        {
            foreach (var request in MatteoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            var ips = (await store.IpAddressesAsync(DateTime.Today));
            Assert.Single(ips);
            Assert.Single((await store.IpAddressesAsync(DateTime.MinValue, DateTime.MaxValue)));
        }

        public static async Task TestRequestByIdentity(IAnalyticStore store)
        {
            foreach (var request in MatteoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            foreach (var request in FrancoRequests)
            {
                await store.StoreWebRequestAsync(request);
            }

            Assert.Equal(MatteoRequests.Length, (await store.RequestByIdentityAsync("MATTEO")).Count());
            Assert.Equal(FrancoRequests.Length, (await store.RequestByIdentityAsync("FRANCO")).Count());
        }

        public static async Task TestGeoResolve(IAnalyticStore store)
        {
            await store.StoreGeoIpRangeAsync(IPAddress.Parse("86.44.0.0"), IPAddress.Parse("86.49.47.255"),
                CountryCode.CZ);

            await store.StoreGeoIpRangeAsync(IPAddress.Parse("85.44.0.0"), IPAddress.Parse("86.43.255.255"),
                CountryCode.SK);

            await store.StoreGeoIpRangeAsync(IPAddress.Parse("86.49.48.0"), IPAddress.Parse("86.86.255.255"),
                CountryCode.IT);

            Assert.Equal(CountryCode.CZ, await store.ResolveCountryCodeAsync(IPAddress.Parse("86.49.47.89")));
        }
    }
}