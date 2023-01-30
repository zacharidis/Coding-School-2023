using EF.CoffeeShop.Orm.Configurations;
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
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionLine> TransactionLines { get; set; }

        public DbSet<MonthlyLedger> MonthlyLedgers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customer> Customers { get; set; }


        // overrides 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
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
