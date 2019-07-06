using MaxMind.Db;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ServerSideAnalytics.GeoLite
{
    public class MaxMindGeoIpResolver : IGeoIpResolver
    {
        private readonly Reader reader;

        public MaxMindGeoIpResolver(string filePath)
        {
            reader = new Reader(filePath);
        }

        public Task PurgeGeoIpAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            var found = reader.Find<Dictionary<string, object>>(address);

            if (found == null) return Task.FromResult(CountryCode.World);

            if(found.ContainsKey("country"))
            {
                var country = found["country"] as Dictionary<string,object>;

                if (country == null || !country.ContainsKey("iso_code")) return Task.FromResult(CountryCode.World);

                return Task.FromResult((CountryCode) Enum.Parse(typeof(CountryCode), country["iso_code"].ToString(), true));
            }

            return Task.FromResult(CountryCode.World);
        }

        public Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
