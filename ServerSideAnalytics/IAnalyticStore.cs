using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

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
        /// Return unique identities that made at least a request on that day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> UniqueIdentitiesAsync(DateTime day);

        /// <summary>
        /// Return unique identities that made at least a request inside the gived ime interval
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> UniqueIdentitiesAsync(DateTime from, DateTime to);

        /// <summary>
        /// Return unique identities that made at least a request on that day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        Task<long> CountUniqueIdentitiesAsync(DateTime day);

        /// <summary>
        /// Return unique identities that made at least a request inside the gived ime interval
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<long> CountUniqueIdentitiesAsync(DateTime from, DateTime to);

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

        /// <summary>
        /// Return all the request made by this identity
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity);

        /// <summary>
        /// Add a geocoding ip range.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode);

        /// <summary>
        /// Makes the geeo ip resolution of incoming request. Internally invoked by ServerSideAQnalytics
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<CountryCode> ResolveCountryCodeAsync(IPAddress address);

        /// <summary>
        /// Remove all item in request collection
        /// </summary>
        /// <returns></returns>
        Task PurgeRequestAsync();

        /// <summary>
        /// Remove all items in geo ip resolution collection
        /// </summary>
        /// <returns></returns>
        Task PurgeGeoIpAsync();
    }
}