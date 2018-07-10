using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideAnalytics.Extensions
{
    public static class AnalyticStoreExtensions
    {
        public static async Task<double> DailyAverage(this IAnalyticStore analyticStore,
            DateTime from, DateTime to)
        {
            return (await DailyServed(analyticStore,from, to)).Average(x => x.Served);
        }

        public static async Task<IEnumerable<(DateTime Day, long Served)>> DailyServed
            (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            return (await analyticStore.InTimeRange(from, to))
                .GroupBy(x => x.Timestamp.Date)
                .Select(x => (x.Key, x.LongCount()));
        }

        public static async Task<IEnumerable<(int Hour, long Served)>> HourlyServed
    (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            return (await analyticStore.InTimeRange(from, to))
                .GroupBy(x => x.Timestamp.Hour)
                .Select(x => (x.Key, x.LongCount()));
        }

        public static async Task<IEnumerable<(string Url, long Served)>> UrlServed
    (this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            return (await analyticStore.InTimeRange(from, to))
                .GroupBy(x => x.Path)
                .Select(x => (x.Key, x.LongCount()));
        }

        public static async Task<IEnumerable<(string Country, long Served)>> ServedByCountry
(this IAnalyticStore analyticStore, DateTime from, DateTime to)
        {
            return (await analyticStore.InTimeRange(from, to))
                .GroupBy(x => x.CountryCode)
                .Select(x => (Country.FromCode(x.Key).CommonName, x.LongCount()));
        }

        public static IAnalyticStore UseIpInfoFailOver(this IAnalyticStore store)
        {
            return new IpInfoAnalyticStore(store);
        }

        public static IAnalyticStore UseIpStackFailOver(this IAnalyticStore store, string key)
        {
            return new IpStackAnalyticStore(store, key);
        }

        public static IAnalyticStore UseIpApiFailOver(this IAnalyticStore store)
        {
            return new IpApiAnalyticStore(store);
        }
    }
}
