﻿using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(Product => Product.ProductID);
            builder.Property(Product=>Product.ProductID).ValueGeneratedOnAdd();
            builder.Property(Product => Product.Code).HasMaxLength(50);
            builder.Property(Product=>Product.Description).HasMaxLength(250);
            builder.Property(Product => Product.ProductCategoryID);
            
                








        }
    }
}


