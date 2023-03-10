using GZFuel.EF.Configurations;
using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Context
{
    // add the dbcontext here :)
    public class FuelDbContext : DbContext
    {

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionLine> TransactionsLines { get; set; }

        // OnModelCreating 
        // OnModelConfiguring 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // Configurations 
           modelBuilder.ApplyConfiguration(new AdminConfiguration());
           modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            
           
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());


            

            

            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DEVCORE\\SQLEXPRESS;Initial Catalog=gzfuelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;"); // connection string goes here

            base.OnConfiguring(optionsBuilder);
        }



    }
}
