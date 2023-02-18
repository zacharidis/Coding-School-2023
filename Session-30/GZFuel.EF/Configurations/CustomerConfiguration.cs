using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GZFuel.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            //table 
            builder.ToTable("Customer");
            builder.HasKey(c => c.ID);

            //properties
            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(c => c.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.CardNumber).HasMaxLength(50).IsRequired(true);

            builder.Property(c => c.ID)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            //relationships




        }
    }
}
