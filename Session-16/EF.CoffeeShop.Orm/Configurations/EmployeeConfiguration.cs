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
            builder.HasKey(Employee => Employee.ID);
            builder.Property(Employee => Employee.Name).HasMaxLength(20);
            builder.Property(Employee => Employee.Surname).HasMaxLength(20);
            builder.Property(Employee => Employee.Salary);
            

        }
    }
}
