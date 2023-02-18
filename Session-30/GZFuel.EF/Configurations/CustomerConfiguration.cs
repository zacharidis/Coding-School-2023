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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           
            //table 
            builder.ToTable("Customer");
            builder.HasKey(c => c.ID);
            
            //properties
            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired(true);
            
            builder.Property(c => c.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.CardNumber).HasMaxLength(50).IsRequired(true);
            
            builder.Property(c => c.ID)
                .ValueGeneratedOnAdd()
                .IsRequired(true);
            
            //relationships
            



        }
    }
}
