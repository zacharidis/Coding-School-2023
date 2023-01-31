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
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(50);
            builder.Property(employee => employee.Surname).HasMaxLength(50);
            builder.Property(employee => employee.Salary);
            

        }
    }
}
