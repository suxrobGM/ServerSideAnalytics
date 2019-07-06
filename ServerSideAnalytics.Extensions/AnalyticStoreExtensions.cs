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
            var seq = (await DailyServed(analyticStore, from, to)).ToArray();
            return seq.Length > 0 ? seq.Average(x => x.Served) : 0;
        }

        public static async Task<IEnumerable<(DateTime Day, long Served)>> DailyServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            var r = (await analyticStore.InTimeRange(from, to)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Timestamp.Date)
                    .Select(x => (x.Key, x.LongCount()))
                : new (DateTime Day, long Served)[0];
        }

        public static async Task<IEnumerable<(int Hour, long Served)>> HourlyServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            var r = (await analyticStore.InTimeRange(from, to)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Timestamp.Hour)
                    .Select(x => (x.Key, x.LongCount()))
                : new (int Hour, long Served)[0];
        }

        public static async Task<IEnumerable<(string Url, long Served)>> UrlServed (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            var r = (await analyticStore.InTimeRange(from, to)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.Path)
                   .Select(x => (x.Key, x.LongCount()))
                : new (string Url, long Served)[0];
        }

        public static async Task<IEnumerable<(string Country, long Served)>> ServedByCountry (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            var r = (await analyticStore.InTimeRange(from, to)).ToArray();

            return r.Length > 0
                ? r.GroupBy(x => x.CountryCode)
                    .Select(x => (Country.FromCode(x.Key).CommonName, x.LongCount()))
                : new (string Country, long Served)[0];
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
