using Libs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("EMPLOYEE");
            //primary key 
            builder.HasKey(employee => employee.ID);
            //properties 
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(50);
            builder.Property(employee => employee.Surname).HasMaxLength(50);
            builder.Property(employee => employee.Salary).HasColumnType("decimal(5,2)").HasPrecision(5, 2);

            // relationships

            builder.HasOne(employee => employee.Transaction).WithOne(transaction => transaction.Employee).HasForeignKey<Transaction>(transaction => transaction.ID);


        }
    }
}
