using SuperMarket.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SuperMarket.Database.Configurations
{
    public class MarketConfigurations : IEntityTypeConfiguration<Market>
    {
        public void Configure(EntityTypeBuilder<Market> builder)
        {
            builder
               .ToTable("Markets");
        }
    }
}
