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
    internal class TransactionLinesConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {

            builder.ToTable("TRANSACTION LINE");
            
            //primary key 
            builder.HasKey(transactionLine => transactionLine.ID);

            //props 
            builder.Property(transactionLine => transactionLine.ID);

            builder.Property(transactionLine => transactionLine.Quantity)
                .HasColumnType("decimal(5,2)").HasPrecision(5, 2);

            builder.Property(transactionLine => transactionLine.Discount)
                .HasColumnType("decimal(5,2)").HasPrecision(5, 2);
            
            builder.Property(transactionLine => transactionLine.Description)
                .HasMaxLength(250);
            
            builder.Property(transactionLine => transactionLine.Price)
                .HasColumnType("decimal(5,2)").HasPrecision(5, 2);

            //relationships 

            builder.HasOne(transactionLine => transactionLine.Product).WithOne(product => product.TransactionLine).HasForeignKey<TransactionLine>(transactionLine => transactionLine.ID);
            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transactionLine => transactionLine.ID);


        }
    }
}
