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
        /// Add a geo-coding ip range.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        Task StoreGeoIpRangeAsync(IPAddress rangeStart, IPAddress rangeEnd, CountryCode countryCode);

        /// <summary>
        /// Makes the geo ip resolution of incoming request. Internally invoked by ServerSideAnalytics
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<CountryCode> ResolveCountryCodeAsync(IPAddress address);
    }
}
