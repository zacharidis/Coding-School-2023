using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configurations
{
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("PRODUCT CATEGORY");
           
            builder.HasKey(ProductCategory => ProductCategory.ProductCategoryID);

            builder.Property(ProductCategory => ProductCategory.ProductCategoryID).ValueGeneratedOnAdd();
            builder.Property(ProductCategory => ProductCategory.Code).HasMaxLength(50);
            builder.Property(ProductCategory => ProductCategory.Description).HasMaxLength(250);
            builder.Property(ProductCategory => ProductCategory.ProductType).GetType();
        }
    }
}
