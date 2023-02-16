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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            
            //table
            builder.ToTable(nameof(Doctor));

            //primary key
            builder.HasKey(d => d.DoctorId);

            builder.Property(d => d.DoctorId).ValueGeneratedOnAdd();

            //properties
            builder.Property(d => d.Surname).HasMaxLength(50).IsRequired();
            builder.Property(d => d.Name).HasMaxLength(50).IsRequired();
          
            builder.Property(d => d.Address).HasMaxLength(50).IsRequired();
            builder.Property(d => d.PhoneNumber).HasMaxLength(50).IsRequired();
            builder.Property(d => d.Specialization).HasMaxLength(50).IsRequired();
            builder.Property(d => d.Email).HasMaxLength(50).IsRequired();


            //relationships

            builder.HasMany(d => d.Consultations).WithOne(c => c.Doctor).HasForeignKey(c => c.Doctor.DoctorId).OnDelete(DeleteBehavior.Restrict);



        }
    }
}
