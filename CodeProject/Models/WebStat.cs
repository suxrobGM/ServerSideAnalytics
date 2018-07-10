using ServerSideAnalytics;
using System;
using System.Collections.Generic;

namespace CodeProject.Models
{
    public class WebStat
    {
        public string Identity { get; set; }
        public long TotalServed { get; internal set; }
        public long UniqueVisitors { get; internal set; }
        public double DailyAverage { get; internal set; }
        public IEnumerable<(DateTime Day, long Served)> DailyServed { get; internal set; }
        public IEnumerable<(int Hour, long Served)> HourlyServed { get; internal set; }
        public IEnumerable<(string Country, long Served)> ServedByCountry { get; internal set; }
        public IEnumerable<(string Url, long Served)> UrlServed { get; internal set; }
        public IEnumerable<WebRequest> Requests { get; internal set; }
    }
}
