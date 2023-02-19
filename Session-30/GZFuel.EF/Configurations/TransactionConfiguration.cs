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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            //properties 

            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.PaymentMethod).IsRequired();
            builder.Property(t => t.TotalValue).IsRequired();
        


            // relationships
           builder.HasOne(t => t.Customer).WithMany(c => c.Transactions).HasForeignKey(t => t.CustomerID);
            builder.HasOne(t=> t.Employee).WithMany(e=>e.Transactions).HasForeignKey(t=>t.EmployeeID);
            builder.HasMany(t=> t.TransactionLines).WithOne(tl => tl.Transaction).HasForeignKey(tl => tl.TransactionID);    

        

           
        }
    }
}
