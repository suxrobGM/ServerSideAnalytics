using System;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Extensions
{
    internal class IpStackGeoResolver : ResolverBase, IGeoIpResolver
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
                var resolved = await _store.ResolveCountryCodeAsync(address).ConfigureAwait(true);

                if(resolved == CountryCode.World)
                {
                    var obj = await LoadJson(new Uri($"http://api.ipstack.com/{address}?access_key={_accessKey}&format=1")).ConfigureAwait(true);

                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country_code"].ToString());

                    await _store.StoreGeoIpRangeAsync(address, address, resolved).ConfigureAwait(false);

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
