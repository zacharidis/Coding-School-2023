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
    public  class ConsultationConfiguration : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(EntityTypeBuilder<Consultation> builder)
        {
            
            //table 
            builder.ToTable(nameof(Consultation));

            //primary key
            builder.HasKey(c => c.ConsultationId);
            builder.Property(c => c.ConsultationId).ValueGeneratedOnAdd();

            //properties
            builder.Property(c => c.Date).IsRequired();
            builder.Property(c => c.Diagnosis).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Treatment).HasMaxLength(50).IsRequired();

            //relationships

            builder.HasOne(c => c.Doctor).WithMany(d => d.Consultations).HasForeignKey(c => c.Doctor.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Patient).WithMany(p => p.Consultations).HasForeignKey(c => c.Patient.Id).OnDelete(DeleteBehavior.Restrict);






        }

    }
}
