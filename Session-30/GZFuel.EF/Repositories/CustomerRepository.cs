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
            if (entity.ID != 0 )
            {
                throw new ArgumentException("Customer cannot have a predefined ID");
            } else
            {
                
                ctx.Customers.Add(entity);
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
            if (dbCustomer != null)
            {
                ctx.Customers.Remove(dbCustomer);
                ctx.SaveChanges();
            } else
            {
                throw new KeyNotFoundException($"Customer with id '{id}' not found");
            }
            
            // maybe i could use the GetById to find the c ustomer for less code. 

        }

        public IEnumerable<Customer> GetAll()
        {
            using var ctx = new FuelDbContext();
            var dbCustomer  = ctx.Customers
                .Include( c=> c.Transactions).ToList();
            return dbCustomer;
        }

        public Customer? GetById(int id)
        {
            using var ctx = new FuelDbContext();

            var selectedCustomer = ctx.Customers.SingleOrDefault(c => c.ID == id);

            if (selectedCustomer != null)
            {
				return selectedCustomer;
			}
			else
            {
				throw new KeyNotFoundException($"Customer with id '{id}' not found");
			}
            
           
        }

        public void Update(int id, Customer entity)
        {
            using var ctx = new FuelDbContext();
            var dbCustomer = ctx.Customers
                .Where(c => c.ID == id)
                .SingleOrDefault();
            if (dbCustomer!= null)
            {
                throw new KeyNotFoundException($"The specific id '{id}' coudnot be found");
            }else
            {
                dbCustomer.Name = entity.Name;
                dbCustomer.Surname = entity.Surname;
                dbCustomer.CardNumber = entity.CardNumber; // maybe we shouldn't change this prop
                ctx.Update( dbCustomer );
                ctx.SaveChanges();


            }
        }
    }

}
