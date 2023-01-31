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
           
            builder.HasKey(productCategory => productCategory.ProductCategoryID);

            builder.Property(productCategory => productCategory.ProductCategoryID).ValueGeneratedOnAdd();
            builder.Property(productCategory => productCategory.Code).HasMaxLength(50);
            builder.Property(productCategory => productCategory.Description).HasMaxLength(250);
            
        }
    }
}
