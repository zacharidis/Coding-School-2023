using Microsoft.EntityFrameworkCore;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");
            builder.HasKey(product => product.ProductID);
            builder.Property(product=>product.ProductID).ValueGeneratedOnAdd();
            builder.Property(product => product.Code).HasMaxLength(50);
            builder.Property(product => product.Description).HasMaxLength(250);
            builder.Property(product => product.ProductCategoryID);
            
                








        }
    }
}


