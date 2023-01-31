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
            builder.HasKey(customer => customer.ID );
            builder.Property(customer => customer.Code).HasMaxLength(5);
            builder.Property(customer => customer.Description).HasMaxLength(20);
            
            //define the relationships
           

            


        }
    }
}
