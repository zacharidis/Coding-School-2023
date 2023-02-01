using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandEF.Domain.Model;
using UnderstandEF.Orm.Configurations;

namespace UnderstandEF.Orm.Context
{
    public  class PoetryDbContext : DbContext
    {
        DbSet<Poet> Poets { get; set; }
        DbSet<Poem> Poems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source = COREDEV\\SQLEXPRESS; Initial Catalog=PoetryDB; Encryption=False;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PoetConfiguration());
            modelBuilder.ApplyConfiguration(new PoemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
