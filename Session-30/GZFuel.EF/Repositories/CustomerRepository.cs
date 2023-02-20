using GZFuel.EF.Context;
using GZFuel.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Repositories
{
    public class CustomerRepository : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var ctx = new FuelDbContext();
            if (entity == null)
            {
                throw new Exception("Entity is not complete");
            } else
            {
                ctx.Add(entity);
                ctx.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using var ctx = new FuelDbContext();
            //go get the specific Customer
            var dbCustomer = ctx.Customers
                .Where(c => c.ID == id)
                .SingleOrDefault();
            ctx.Remove(dbCustomer);
            ctx.SaveChanges();
            // maybe i could use the GetById to find the c ustomer for less code. 

        }

        public IList<Customer> GetAll()
        {
            using var ctx = new FuelDbContext();
            var dbCustomer  = ctx.Customers
                .Include( c=> c.Transactions).ToList();
            return dbCustomer;
        }

        public Customer? GetById(int id)
        {
            using var ctx = new FuelDbContext();
            var dbCustomer = ctx.Customers
                .Where (c => c.ID == id)
                .Include(c=> c.Transactions)
                .SingleOrDefault();
            return dbCustomer;
        }

        public void Update(int id, Customer entity)
        {
            throw new NotImplementedException();
        }
    }

}
