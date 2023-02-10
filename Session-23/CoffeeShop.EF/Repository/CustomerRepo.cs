using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id, Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
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
