using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandEF.Domain.Model;

namespace UnderstandEF.Orm.Configurations
{
    public class PoetConfiguration : IEntityTypeConfiguration<Poet>
    {
        public void Configure(EntityTypeBuilder<Poet> builder)
        {

            builder.ToTable("POET");
            builder.HasKey(poet => poet.Id);
            builder.Property(poet => poet.Id).ValueGeneratedOnAdd();
            builder.Property(poet => poet.Name).HasMaxLength(50);
            builder.Property(poet => poet.Surname).HasMaxLength(50);

            //TODO Add reference to poems


        }
    }
}
