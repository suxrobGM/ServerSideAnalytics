using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Maddalena;

namespace ServerSideAnalytics
{
    public interface IAnalyticStore
    {
        /// <summary>
        /// Store recivied request. Internally invoked by ServerSideAnalytics
        /// </summary>
        /// <param name="request">Request collected by ServerSideAnalytics</param>
        /// <returns></returns>
        Task StoreWebRequestAsync(WebRequest request);

        /// <summary>
        /// Return unique indentities that made at least a request on that day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        Task<long> CountUniqueIndentitiesAsync(DateTime day);

        /// <summary>
        /// Return unique indentities that made at least a request inside the gived ime interval
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<long> CountUniqueIndentitiesAsync(DateTime from, DateTime to);

        /// <summary>
        /// Return the raw number of request served in the time interval
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<long> CountAsync(DateTime from, DateTime to);

        /// <summary>
        /// Return distinct Ip Address served during that day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime day);

        /// <summary>
        /// Return distinct IP addresses served during given time interval
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime from, DateTime to);

        /// <summary>
        /// Return any request that was served during this time range
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<IEnumerable<WebRequest>> InTimeRange(DateTime from, DateTime to);

        Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity);

        Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode);

        Task<CountryCode> ResolveCountryCodeAsync(IPAddress address);

        Task PurgeRequestAsync();

        Task PurgeGeoIpAsync();
    }
}