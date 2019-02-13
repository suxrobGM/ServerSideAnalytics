using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServerSideAnalytics.Extensions
{
    internal class IpInfoAnalyticStore : IAnalyticStore
    {
        private readonly string _token;
        private readonly IAnalyticStore _store;

        public IpInfoAnalyticStore(IAnalyticStore store, string token="")
        {
            _token = token;
            _store = store;
        }

        public Task<long> CountAsync(DateTime from, DateTime to) => _store.CountAsync(from, to);

        public Task<long> CountUniqueIdentitiesAsync(DateTime day) => _store.CountUniqueIdentitiesAsync(day);

        public Task<long> CountUniqueIdentitiesAsync(DateTime from, DateTime to) => _store.CountUniqueIdentitiesAsync(from, to);

        public Task<IEnumerable<WebRequest>> InTimeRange(DateTime from, DateTime to) => _store.InTimeRange(from, to);

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime day) => _store.IpAddressesAsync(day);

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime from, DateTime to) => _store.IpAddressesAsync(from,to);

        public Task PurgeGeoIpAsync() => _store.PurgeGeoIpAsync();

        public Task PurgeRequestAsync() => _store.PurgeRequestAsync();

        public Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity) => _store.RequestByIdentityAsync(identity);

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            try
            {
                var resolved = await _store.ResolveCountryCodeAsync(address);

                if(resolved == CountryCode.World)
                {
                    var ipstr = address.ToString();
                    var response = await (new HttpClient()).GetStringAsync($"https://ipinfo.io/{ipstr}??token={_token}");

                    var obj = JsonConvert.DeserializeObject(response) as JObject;
                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country"].ToString());

                    await _store.StoreGeoIpRangeAsync(address, address, resolved);

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
            return _store.StoreGeoIpRangeAsync(from, to, countryCode);
        }

        public Task StoreWebRequestAsync(WebRequest request)
        {
            return _store.StoreWebRequestAsync(request);
        }
    }
}
