using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServerSideAnalytics.Extensions
{
    internal class IpStackGeoResolver : IGeoIpResolver
    {
        private readonly string _accessKey;
        private readonly IGeoIpResolver _store;

        public IpStackGeoResolver(IGeoIpResolver store, string token)
        {
            _accessKey = token;
            _store = store;
        }

        public Task PurgeGeoIpAsync() => _store.PurgeGeoIpAsync();

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            try
            {
                var resolved = await _store.ResolveCountryCodeAsync(address);

                if(resolved == CountryCode.World)
                {
                    var ipstr = address.ToString();
                    var response = await (new HttpClient()).GetStringAsync($"http://api.ipstack.com/{ipstr}?access_key={_accessKey}&format=1");

                    var obj = JsonConvert.DeserializeObject(response) as JObject;
                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country_code"].ToString());

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
    }
}
