using Libs;
using Microsoft.EntityFrameworkCore;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Context
{
    internal class CoffeeShopDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Transaction> transactions { get; set; }

        public DbSet<TransactionLine> transactionLines { get; set; }

        public DbSet<MonthlyLedger> monthlyLedgers { get; set; }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Customer> customers { get; set; }


        // overrides 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =COREDEV\\SQLEXPRESS; Initial Catalog =CoffeeShopDb; Integrated Security=True;Connect Timeout=30" +
                "Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
