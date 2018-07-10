using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Maddalena;
using Microsoft.EntityFrameworkCore;

namespace ServerSideAnalytics.SqLite
{
    public class SqLiteAnalyticStore : IAnalyticStore
    {
        private static readonly IMapper Mapper;
        private readonly string _connectionString;

        private string _requestTable = "SSARequest";
        private string _geoIpTable = "SSAGeoIP";

        private bool _firstCall;

        static SqLiteAnalyticStore()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WebRequest, SqliteWebRequest>()
                    .ForMember(dest => dest.RemoteIpAddress, x => x.MapFrom(req => req.RemoteIpAddress.ToString()));

                cfg.CreateMap<SqliteWebRequest, WebRequest>()
                    .ForMember(dest => dest.RemoteIpAddress, x => x.MapFrom(req => IPAddress.Parse(req.RemoteIpAddress)));
            });

            Mapper = config.CreateMapper();
        }

        private SqLiteContext GetContext()
        {
            var context = new SqLiteContext(_connectionString, _requestTable, _geoIpTable);
            if (!_firstCall)
            {
                context.Database.EnsureCreated();
                _firstCall = true;
            }
            return context;
        }

        public SqLiteAnalyticStore():this("Data Source = stat.db")
        {

        }

        public SqLiteAnalyticStore(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqLiteAnalyticStore RequestTable(string tablename)
        {
            _requestTable = tablename;
            return this;
        }

        public SqLiteAnalyticStore GeoIpTable(string tablename)
        {
            _geoIpTable = tablename;
            return this;
        }

        public async Task StoreWebRequestAsync(WebRequest request)
        {
            using (var db = GetContext())
            {
                await db.Database.EnsureCreatedAsync();
                await db.WebRequest.AddAsync(Mapper.Map<SqliteWebRequest>(request));
                await db.SaveChangesAsync();
            }
        }

        public Task<long> CountUniqueIndentitiesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return CountUniqueIndentitiesAsync(from, to);
        }

        public async Task<long> CountUniqueIndentitiesAsync(DateTime from, DateTime to)
        {
            using (var db = GetContext())
            {
                return await db.WebRequest.Where(x => x.Timestamp >= from && x.Timestamp <= to).GroupBy(x => x.Identity).CountAsync();
            }
        }

        public async Task<long> CountAsync(DateTime from, DateTime to)
        {
            using (var db = GetContext())
            {
                return await db.WebRequest.Where(x => x.Timestamp >= from && x.Timestamp <= to).CountAsync();
            }
        }

        public Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime day)
        {
            var from = day.Date;
            var to = day + TimeSpan.FromDays(1);
            return IpAddressesAsync(from, to);
        }

        public async Task<IEnumerable<IPAddress>> IpAddressesAsync(DateTime from, DateTime to)
        {
            using (var db = GetContext())
            {
                var ip = await db.WebRequest.Where(x => x.Timestamp >= from && x.Timestamp <= to)
                    .Select(x => x.RemoteIpAddress)
                    .Distinct()
                    .ToListAsync();

                return ip.Select(IPAddress.Parse).ToArray();
            }
        }

        public async Task<IEnumerable<WebRequest>> RequestByIdentityAsync(string identity)
        {
            using (var db = GetContext())
            {
                return await db.WebRequest.Where(x => x.Identity == identity).Select( x => Mapper.Map<WebRequest>(x)).ToListAsync();
            }
        }

        public async Task StoreGeoIpRangeAsync(IPAddress from, IPAddress to, CountryCode countryCode)
        {
            var bytesFrom = from.GetAddressBytes();
            var bytesTo = to.GetAddressBytes();

            Array.Resize(ref bytesFrom, 16);
            Array.Resize(ref bytesTo, 16);

            using (var db = GetContext())
            {
                await db.Database.EnsureCreatedAsync();

                await db.GeoIpRange.AddAsync(new SqLiteGeoIpRange
                {
                    FromDown = BitConverter.ToInt64(bytesFrom, 0),
                    FromUp = BitConverter.ToInt64(bytesFrom, 8),

                    ToDown = BitConverter.ToInt64(bytesTo, 0),
                    ToUp = BitConverter.ToInt64(bytesTo, 8),
                    CountryCode = countryCode
                });

                await db.SaveChangesAsync();
            }
        }

        public async Task<CountryCode> ResolveCountryCodeAsync(IPAddress address)
        {
            var bytes = address.GetAddressBytes();
            Array.Resize(ref bytes, 16);

            var down = BitConverter.ToInt64(bytes, 0);
            var up = BitConverter.ToInt64(bytes, 8);

            using (var db = GetContext())
            {
                var found = await db.GeoIpRange.FirstOrDefaultAsync(x =>
                    x.FromDown <= down && x.ToDown >= down && x.FromUp <= up && x.ToUp >= up);

                return found?.CountryCode ?? CountryCode.World;
            }
        }

        public async Task PurgeRequestAsync()
        {
            using (var db = GetContext())
            {
                await db.Database.EnsureCreatedAsync();
                db.WebRequest.RemoveRange(db.WebRequest);
                await db.SaveChangesAsync();
            }

        }

        public async Task PurgeGeoIpAsync()
        {
            using (var db = GetContext())
            {
                await db.Database.EnsureCreatedAsync();
                db.GeoIpRange.RemoveRange(db.GeoIpRange);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<WebRequest>> InTimeRange(DateTime from, DateTime to)
        {
            using (var db = GetContext())
            {
                return (await db.WebRequest.Where(x => x.Timestamp >= from && x.Timestamp <= to)
                    .ToListAsync())
                    .Select(x => Mapper.Map<WebRequest>(x))
                    .ToList();
            }
        }
    }
}