using Maddalena;

namespace ServerSideAnalytics.SqlServer
{
    internal class SqlServerGeoIpRange
    {
        public long Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public CountryCode CountryCode { get; set; }
    }
}
