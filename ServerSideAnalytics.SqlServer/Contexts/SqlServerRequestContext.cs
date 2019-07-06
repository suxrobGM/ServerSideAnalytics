using Microsoft.EntityFrameworkCore;

namespace ServerSideAnalytics.SqlServer
{
    internal class SqlServerRequestContext : DbContext
    {
        private readonly string _requestTable;
        private readonly string _connectionString;

        public SqlServerRequestContext(string connectionString, string requestTable)
        {
            _connectionString = connectionString;
            _requestTable = requestTable;
        }

        public DbSet<SqlServerWebRequest> WebRequest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SqlServerWebRequest>(b => { b.ToTable(_requestTable); });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}