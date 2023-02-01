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
    public class PoemConfiguration : IEntityTypeConfiguration<Poem>
    {
        public void Configure(EntityTypeBuilder<Poem> builder)
        {
            builder.ToTable("Poem");
            builder.HasKey(poem => poem.Id);
            builder.Property(poem => poem.Id).ValueGeneratedOnAdd();
            builder.Property(poem=>poem.PoemName).IsRequired(true).HasMaxLength(256);
            builder.Property(poem=>poem.PoemBody).IsRequired(true).HasMaxLength(1024);
            
            //references here during the next step of EF
        }
    }
}
