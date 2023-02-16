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
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
       

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
           
            //table 
            builder.ToTable(nameof(Patient));

            //primary key
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            //properties
            builder.Property(p => p.Surname).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(50).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.AMKA).HasMaxLength(50);

      









        }
    }
}
