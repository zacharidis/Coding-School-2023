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
           
        }
    }
}
