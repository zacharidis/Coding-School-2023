using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
      

        public void Configure(EntityTypeBuilder<Item> builder)
        {
            //table
            builder.ToTable("Item");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();

            //properties
            builder.Property(i => i.Code)
                .HasMaxLength(10)
                .IsRequired(true);  

            builder.Property(i=> i.Cost).HasPrecision(3,2).IsRequired(true);
            builder.Property(i=> i.Price).HasPrecision(3,2).IsRequired(true);   
            builder.Property(i => i.Description).HasMaxLength(250).IsRequired(true);
            builder.Property(i => i.ItemType).HasMaxLength(50).IsRequired(true);
                









        }
    }
}
