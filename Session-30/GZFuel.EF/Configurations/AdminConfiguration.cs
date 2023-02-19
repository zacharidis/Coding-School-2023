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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            //table 
            builder.ToTable("Admin");
            builder.HasKey(a => a.Id);

            //properties
            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(c => c.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(a=>a.Password).HasMaxLength(50).IsRequired(true).HasDefaultValue(true);
            builder.Property(a => a.Username).HasMaxLength(50).IsRequired(true).HasDefaultValue(true);

            //relationships
        }
    }
    {
    }
}
