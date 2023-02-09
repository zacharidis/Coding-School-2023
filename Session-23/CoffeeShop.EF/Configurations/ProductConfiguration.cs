using CoffeeShop.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Table Name
            builder.ToTable("Products");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Code).HasMaxLength(20).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(150).IsRequired();
            builder.Property(t => t.Price).HasPrecision(3, 2).IsRequired();
            builder.Property(t => t.Cost).HasPrecision(3, 2).IsRequired();

            // Relations
            builder.HasOne(t => t.ProductCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(t => t.ProductCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
