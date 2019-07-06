using Microsoft.EntityFrameworkCore;

namespace ServerSideAnalytics.SqlServer
{
    internal class SqlServerGeoIpContext : DbContext
    {
        private readonly string _geoIpTable;
        private readonly string _connectionString;

        public SqlServerGeoIpContext(string connectionString,string geoIpTable)
        {
            _connectionString = connectionString;
            _geoIpTable = geoIpTable;
        }

        public DbSet<SqlServerGeoIpRange> GeoIpRange { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SqlServerGeoIpRange>(b => { b.ToTable(_geoIpTable); });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}