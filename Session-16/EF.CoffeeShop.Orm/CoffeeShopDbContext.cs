using Libs;
using Microsoft.EntityFrameworkCore;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm
{
    internal class CoffeeShopDbContext
    {
        public DbSet<Product> products { get; set; }

        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Transaction> transactions { get; set; }

        public DbSet<TransactionLine> transactionLines { get; set; }

        public DbSet<MonthlyLedger> monthlyLedgers { get; set; }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Customer> customers { get; set; }



     

    }
}
