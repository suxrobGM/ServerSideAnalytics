using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServerSideAnalytics.Extensions
{
    class IpStackAnalyticStore : IAnalyticStore
    {
        string accessKey;
        IAnalyticStore store;

        public IpStackAnalyticStore(IAnalyticStore store, string token)
        {
            this.accessKey = token;
            this.store = store;
        }

        public Task<long> CountAsync(DateTime from, DateTime to) => store.CountAsync(from, to);

        public Task<long> CountUniqueIndentitiesAsync(DateTime day) => store.CountUniqueIndentitiesAsync(day);

        public Task<long> CountUniqueIndentitiesAsync(DateTime from, DateTime to) => store.CountUniqueIndentitiesAsync(from, to);

        public Task<IEnumerable<WebRequest>> InTimeRange(DateTime from, DateTime to) => store.InTimeRange(from, to);

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime day) => store.IpAddressesAsync(day);

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime from, DateTime to) => store.IpAddressesAsync(from,to);

        public Task PurgeGeoIpAsync() => store.PurgeGeoIpAsync();

        public Task PurgeRequestAsync() => store.PurgeRequestAsync();

        public Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity) => store.RequestByIdentityAsync(identity);

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            try
            {
                var resolved = await store.ResolveCountryCodeAsync(address);

                if(resolved == CountryCode.World)
                {
                    var ipstr = address.ToString();
                    var response = await (new HttpClient()).GetStringAsync($"http://api.ipstack.com/{ipstr}?access_key={accessKey}&format=1");

                    var obj = JsonConvert.DeserializeObject(response) as JObject;
                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country_code"].ToString());

                    await store.StoreGeoIpRangeAsync(address, address, resolved);

                    return resolved;
                }

                return resolved;
            }
            catch (Exception)
            {
            }
            return CountryCode.World;
        }

        public Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            return store.StoreGeoIpRangeAsync(from, to, countryCode);
        }

        public Task StoreWebRequestAsync(WebRequest request)
        {
            return store.StoreWebRequestAsync(request);
        }
    }
}
