using GZFuel.Model.Entities;
using GZFuel.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
            //table 
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired(true);

            //properties

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired(true);
            builder.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsRequired(true);
            builder.Property(e => e.HireDateStart)
                .IsRequired(true);
            builder.Property(e => e.HireDateEnd)
                .IsRequired(false); // employee can be fired so it's nullable 

            builder.Property(e => e.SalaryPerMonth).HasColumnType("integer").IsRequired(true);
          
            
            //---------------------------------------------- get the string value out of enum and store it in the database

            builder.Property(e => e.EmployeeType)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasConversion(


                v => v.ToString(),
                                   v => (EmployeeType)Enum.Parse(typeof(EmployeeType), v));



            // relationships with transactions

            builder.HasMany(e => e.Transactions).WithOne(t => t.Employee)
                .HasForeignKey(t => t.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);









        }
    }
}
