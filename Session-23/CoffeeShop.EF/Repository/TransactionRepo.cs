using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    public class TransactionRepo : IEntityRepo<Transaction>
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
            using var context = new CoffeeShopDbContext();
           return context.Transactions.ToList();


            
        }

        public Transaction? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var selectedTransaction = context.Transactions.SingleOrDefault(t=>t.Id == id);
            if (selectedTransaction != null)
            {
                return selectedTransaction;
            } else
            {
                throw new Exception("Transaction not found ");
            }
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedTransaction = context.Transactions.SingleOrDefault(t=>t.Id == id);
            if (selectedTransaction != null)
            {
                selectedTransaction.TotalPrice= entity.TotalPrice;
                selectedTransaction.TransactionLines= entity.TransactionLines;
                selectedTransaction.Employee.Id= entity.Employee.Id;
                selectedTransaction.CustomerId= entity.Customer.Id;
                selectedTransaction.PaymentMethod= entity.PaymentMethod;
                selectedTransaction.Date = entity.Date;
                context.SaveChanges();

            } else
            {
                throw new Exception("Transaction Not found !");
            }
        }
    }
}
