using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Database.Models;

namespace SuperMarket.Database.Configurations
{
    public class CategoryConfigurations: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
               .ToTable("Categories");
        }
    }
}
