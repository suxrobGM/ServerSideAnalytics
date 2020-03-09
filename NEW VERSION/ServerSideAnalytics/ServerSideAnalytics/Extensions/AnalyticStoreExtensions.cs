using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Extensions
{
    public static class AnalyticStoreExtensions
    {
        public static async Task<double> DailyAverage(this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            var seq = (await DailyServed(analyticStore, from, to).ConfigureAwait(true)).ToArray();
            return seq.Length > 0 ? seq.Average(x => x.Served) : 0;
        }

        public static async Task<IEnumerable<(DateTime Day, long Served)>> DailyServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            if(analyticStore == null) throw new ArgumentNullException(nameof(analyticStore));

            var r = (await analyticStore.InTimeRange(from, to).ConfigureAwait(true)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Timestamp.Date)
                    .Select(x => (x.Key, x.LongCount()))
                : Array.Empty<(DateTime Day, long Served)>();
        }

        public static async Task<IEnumerable<(int Hour, long Served)>> HourlyServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            if(analyticStore == null) throw new ArgumentNullException(nameof(analyticStore));

            var r = (await analyticStore.InTimeRange(from, to).ConfigureAwait(true)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Timestamp.Hour)
                    .Select(x => (x.Key, x.LongCount()))
                : Array.Empty<(int Hour, long Served)>();
        }

        public static async Task<IEnumerable<(string Url, long Served)>> UrlServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            if(analyticStore == null) throw new ArgumentNullException(nameof(analyticStore));

            var r = (await analyticStore.InTimeRange(from, to).ConfigureAwait(true)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Path)
                   .Select(x => (x.Key, x.LongCount()))
                : Array.Empty<(string Url, long Served)>();
        }

        public static async Task<IEnumerable<(string Country, long Served)>> ServedByCountry (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            if(analyticStore == null) throw new ArgumentNullException(nameof(analyticStore));

            var r = (await analyticStore.InTimeRange(from, to)
                .ConfigureAwait(true)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.CountryCode)
                    .Select(x => (Country.FromCode(x.Key).CommonName, x.LongCount()))
                : Array.Empty<(string Country, long Served)>();
        }

        public static IGeoIpResolver UseIpInfoFailOver(this IGeoIpResolver store)
        {
            return new IpInfoGeoResolver(store);
        }

        public static IGeoIpResolver UseIpStackFailOver(this IGeoIpResolver store, string key)
        {
            return new IpStackGeoResolver(store, key);
        }

        public static IGeoIpResolver UseIpApiFailOver(this IGeoIpResolver store)
        {
            return new IpApiGeoResolver(store);
        }
    }
}
