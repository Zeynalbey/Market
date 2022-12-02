using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Database.Models;

namespace SuperMarket.Database.Configurations
{
    public class MarketProductConfigurations : IEntityTypeConfiguration<MarketProduct>
    {
        public void Configure(EntityTypeBuilder<MarketProduct> builder)
        {
            builder
                .ToTable("MarketProducts");

            builder
                .HasKey(mp => new { mp.MarketId, mp.ProductId });

            builder
               .HasOne(mp => mp.Product)
               .WithMany(p => p.MarketProducts)
               .HasForeignKey(mp => mp.ProductId);

            builder
                .HasOne(mp => mp.Market)
                .WithMany(m => m.MarketProducts)
                .HasForeignKey(mp => mp.MarketId);
        }


    }
}
