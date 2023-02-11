using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id, TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedTransactionLine = context.TransactionLines.SingleOrDefault(tl=> tl.Id == id);   
            if (selectedTransactionLine != null)
            {
                context.TransactionLines.Remove(selectedTransactionLine);
                context.SaveChanges();
            } else
            {
                throw new Exception("TransactionLine not found!");
            }
        }

        public IEnumerable<TransactionLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransactionLine? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TransactionLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
