using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id, Customer entity)
        {
            using var context = new CoffeeShopDbContext();
            var customerExists= context.Customers.SingleOrDefault(x => x.Id == id); 
            if (customerExists != null)
            {
                context.Customers.Remove(customerExists);
                context.SaveChanges();
            } else
            {
                throw new Exception("There's no customer to delete");
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Customers.ToList();

        }

        public Customer? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Customers.SingleOrDefault(Customer=>Customer.Id == id);

        }

        public void Update(int id, Customer entity)
        {
            using var context = new CoffeeShopDbContext();
            var customerExists = context.Customers.SingleOrDefault(Customer => Customer.Id == id);  
            if (customerExists != null)
            {
                customerExists.Code= entity.Code;
                customerExists.Description= entity.Description;
                context.SaveChanges();
            } else
            {
                throw new Exception("Customer is missing , cannot be updated");
            }

        }
    }
}
