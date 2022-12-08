using Microsoft.EntityFrameworkCore;
using SuperMarket.Database.Models;
using SuperMarket.Extensions;

namespace SuperMarket.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Market> Markets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MarketProduct> MarketProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly<Program>();
        }
    }
}
