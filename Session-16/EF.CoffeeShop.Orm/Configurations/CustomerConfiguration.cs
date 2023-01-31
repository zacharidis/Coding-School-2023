using Libs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configurations
{
    internal class CustomerConfiguration:IEntityTypeConfiguration<Customer>
    {
      

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CUSTOMER");
            builder.HasKey(Customer => Customer.ID );
            builder.Property(Customer => Customer.Code).HasMaxLength(5);
            builder.Property(Customer => Customer.Description).HasMaxLength(20);




        }
    }
}
