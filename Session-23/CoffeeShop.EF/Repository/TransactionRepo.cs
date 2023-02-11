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
            using var context = new CoffeeShopDbContext();
            var selectedTransaction = context.Transactions.SingleOrDefault(t => t.Id == id);
            if (selectedTransaction != null)
            {
                context.Transactions.Remove(selectedTransaction);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Transaction not found!");
            }
            

            
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
