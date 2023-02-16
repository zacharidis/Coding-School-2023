using EpsilonRevision.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.EF.Configurations
{
    public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            //table name goes here 

            builder.ToTable(nameof(Hospital));
           
            //Primary Key
            builder.HasKey(h => h.HospitalId);
            builder.Property(h => h.HospitalId).ValueGeneratedOnAdd();

            // properties 

            builder.Property(h => h.Name).HasMaxLength(50).IsRequired();
            builder.Property(h => h.Address).HasMaxLength(50).IsRequired();
            builder.Property(h=> h.PhoneNumber).HasMaxLength(50).IsRequired();


            // no relations -- we assume the hospital is one - the one using the app

        }
    }
}
