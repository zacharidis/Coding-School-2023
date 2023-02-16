using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpsilonRevision.EF.Configurations;
using EpsilonRevision.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EpsilonRevision.EF.Context
{
    public  class HealthDbContext: DbContext 
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Consultation> Consultations { get; set; } = null;

        public DbSet<HospitalAdmission> HospitalAdmissions { get; set; } = null;
   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new HospitalConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());

           

            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultationConfiguration());
            modelBuilder.ApplyConfiguration(new HospitalAdmissionConfiguration());


        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEV\SQLEXPRESS;Database=HealthDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);

        }
    
    
    
    
    }

      

}
