using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF
{
    // add the dbcontext here :)
    public class FuelDbContext : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionLine> TransactionsLines { get; set; }

       // OnModelCreating 
       // OnModelConfiguring 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

       



    }
}
