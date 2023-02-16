using EpsilonRevision.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.EF.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
       

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            throw new NotImplementedException();
        }
    }
}
