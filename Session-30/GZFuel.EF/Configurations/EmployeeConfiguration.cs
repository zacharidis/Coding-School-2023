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
            builder.Property(e => e.EmployeeType).IsRequired(true);



            // relationships with transactions

            builder.HasMany(e => e.Transactions).WithOne(t => t.Employee)
                .HasForeignKey(t => t.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);









        }
    }
}
