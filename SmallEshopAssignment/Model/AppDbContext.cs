using Microsoft.EntityFrameworkCore;

namespace SmallEshopAssignment.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Seed(builder);
        }

        private void Seed(ModelBuilder builder)
        {
        }

        public DbSet<Customer> Customers { get; set; }
       // public DbSet<Ticker> Tickers { get; set; }
       // public DbSet<Currency> Currencies { get; set; }
    }
}
