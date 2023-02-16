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
    public class HospitalAdmissionConfiguration : IEntityTypeConfiguration<HospitalAdmission>
    {
        public void Configure(EntityTypeBuilder<HospitalAdmission> builder)
        {
            
            //table
            
            builder.ToTable(nameof(HospitalAdmission));

            //primary key

            builder.HasKey(ha => ha.Id);
            builder.Property(ha=>ha.Id).ValueGeneratedOnAdd();

            //properties 
            builder.Property(ha=> ha.Treatment).HasMaxLength(500);
            builder.Property(ha => ha.IsDischarged);
            builder.Property(ha=> ha.Diagnosis).HasMaxLength(500);
            builder.Property(ha=> ha.Clinic).IsRequired();
            builder.HasKey(ha => ha.AdmissionDate);


            //relationships
            






        }
    }
}
