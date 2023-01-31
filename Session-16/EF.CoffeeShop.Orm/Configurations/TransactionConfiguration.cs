using Libs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configurations
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction=> transaction.Date);

            builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal(5,2)").HasPrecision(5, 2);

            //relationships Employee , Customer , TransactionLine 

            builder.HasOne(transaction => transaction.Employee).WithOne(employee => employee.Transaction).HasForeignKey<Transaction>(transaction => transaction.ID);
            builder.HasOne(transaction => transaction.Customer).WithOne(customer => customer.Transaction).HasForeignKey<Transaction>(transaction => transaction.ID);

            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey(transactionLine => transactionLine.ID);


        }
    }
}
