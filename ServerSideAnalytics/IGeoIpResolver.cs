using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics
{
    public interface IGeoIpResolver
    {
        
        /// <summary>
        /// Remove all items in geo ip resolution collection
        /// </summary>
        /// <returns></returns>
        Task PurgeGeoIpAsync();

        /// <summary>
        /// Add a geocoding ip range.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode);

        /// <summary>
        /// Makes the geo ip resolution of incoming request. Internally invoked by ServerSideAQnalytics
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<CountryCode> ResolveCountryCodeAsync(IPAddress address);
    }
}
