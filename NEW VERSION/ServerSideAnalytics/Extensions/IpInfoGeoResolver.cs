using System;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Extensions
{
    internal class IpInfoGeoResolver : ResolverBase, IGeoIpResolver
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
                var resolved = await _resolver.ResolveCountryCodeAsync(address).ConfigureAwait(true);

                if(resolved == CountryCode.World)
                {
                    var uri = new Uri($"https://ipinfo.io/{address}?token={_token}");

                    var obj = await LoadJson(uri).ConfigureAwait(true);

                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country"].ToString());

                    await _resolver.StoreGeoIpRangeAsync(address, address, resolved).ConfigureAwait(false);

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
