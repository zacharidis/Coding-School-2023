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
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.ToList();
        }


        public TransactionLine? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.SingleOrDefault(tl=>tl.Id == id);

        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedTransactionLine = (context.TransactionLines.SingleOrDefault(tl=>tl.Id ==id));  
            if (selectedTransactionLine != null)
            {
                selectedTransactionLine.TotalPrice = entity.TotalPrice;
                selectedTransactionLine.Price = entity.Price;
                selectedTransactionLine.Product = entity.Product; // not sure about that ?!!??
                selectedTransactionLine.Discount = entity.Discount;
                selectedTransactionLine.ProductId   = entity.ProductId;
                selectedTransactionLine.Quantity= entity.Quantity;
                selectedTransactionLine.Transaction = entity.Transaction;
            }
        }
    }
}
