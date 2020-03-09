using System;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Extensions
{
    internal class IpApiGeoResolver : ResolverBase, IGeoIpResolver
    {
        private readonly IGeoIpResolver _resolver;


        public IpApiGeoResolver(IGeoIpResolver store)
        {
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
                    var obj = await LoadJson(new Uri($"http://ip-api.com/json/{address}")).ConfigureAwait(true);

                    resolved = (CountryCode)Enum.Parse(typeof(CountryCode), obj["country_code"].ToString());

                    await _resolver.StoreGeoIpRangeAsync(address, address, resolved).ConfigureAwait(false);

                    return resolved;
                }

                return resolved;
            }
            catch (Exception)
            {
                return CountryCode.World;
            }
        }

        public Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            return _resolver.StoreGeoIpRangeAsync(from, to, countryCode);
        }
    }
}
