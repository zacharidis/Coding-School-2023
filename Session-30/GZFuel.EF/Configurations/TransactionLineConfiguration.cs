using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            //table 
            builder.ToTable("TransactionLine");
            builder.HasKey(tl => tl.ID);

            //properties 
            
            builder.Property(tl => tl.ItemPrice).HasPrecision(5,2).IsRequired(true);
            builder.Property(tl => tl.Quantity).IsRequired(true).HasColumnType("integer");
            builder.Property(tl => tl.TotalValue).HasPrecision(5,2).IsRequired(true);
            builder.Property(tl=> tl.DiscountPercent).HasPrecision(5,2).IsRequired(true);
            builder.Property(tl => tl.DiscountValue).HasPrecision(5,2).IsRequired(true);
            builder.Property(tl => tl.NetValue).HasPrecision(5,2).IsRequired(true);
            

            
           

            // relationships
            builder.HasOne(tl => tl.Transaction).WithMany(t => t.TransactionLines).HasForeignKey(tl => tl.TransactionID);
            builder.HasOne(tl => tl.Item).WithMany(i => i.TransactionLines).HasForeignKey(tl => tl.ItemID);
            













        }
    }
}
