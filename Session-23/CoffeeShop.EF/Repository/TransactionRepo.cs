using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Transactions.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id, Transaction entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transaction? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
