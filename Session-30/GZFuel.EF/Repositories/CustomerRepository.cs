using GZFuel.EF.Context;
using GZFuel.Model.Entities;
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
                .Where(e => e.ID== id)
                .SingleOrDefault();
            ctx.Remove(dbCustomer);
            ctx.SaveChanges();
            // maybe i could use the GetById to find the c ustomer for less code. 

        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Customer entity)
        {
            throw new NotImplementedException();
        }
    }

}
