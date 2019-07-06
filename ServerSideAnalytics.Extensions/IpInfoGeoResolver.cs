using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServerSideAnalytics.Extensions
{
    internal class IpInfoGeoResolver : IGeoIpResolver
    {
        private readonly string _token;
        private readonly IGeoIpResolver _resolver;

        public IpInfoGeoResolver(IGeoIpResolver store, string token="")
        {
            _token = token;
            _resolver = store;
        }

        public Task PurgeGeoIpAsync() => _resolver.PurgeGeoIpAsync();

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            try
            {
                var resolved = await _resolver.ResolveCountryCodeAsync(address);

                if(resolved == CountryCode.World)
                {
                    var ipstr = address.ToString();
                    var response = await (new HttpClient()).GetStringAsync($"https://ipinfo.io/{ipstr}??token={_token}");

                    var obj = JsonConvert.DeserializeObject(response) as JObject;
                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country"].ToString());

                    await _resolver.StoreGeoIpRangeAsync(address, address, resolved);

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
            return _resolver.StoreGeoIpRangeAsync(from, to, countryCode);
        }
    }
}
