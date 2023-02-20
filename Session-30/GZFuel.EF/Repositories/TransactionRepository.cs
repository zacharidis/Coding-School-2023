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
    public class TransactionRepository : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var ctx = new FuelDbContext();
            if (entity.ID != 0)
            {
                throw new ArgumentException("Transaction cannot have a predefined ID", nameof(entity));
            }
            else
            {
                ctx.Transactions.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using var ctx = new FuelDbContext();
            var dbTransaction = ctx.Transactions
                .Where(t => t.ID == id)
                .SingleOrDefault();
            if (dbTransaction != null)
            {
                ctx.Transactions.Remove(dbTransaction);
                ctx.SaveChanges();
            } else
            { throw new KeyNotFoundException($"Transaction with id '{id}' not found");} 

         }


        public IEnumerable<Transaction> GetAll()
        {
            using var ctx = new FuelDbContext();
            var dbTransactions = ctx.Transactions.ToList();
            return dbTransactions;  
        }

        public Transaction? GetById(int id)
        {
            using var ctx = new FuelDbContext();
            var dbTransaction = ctx.Transactions
                .Where(t => t.ID == id)
                .SingleOrDefault();
            if (dbTransaction != null)
            {
                              return dbTransaction;
            }
            else
            {
                throw new KeyNotFoundException($"Transaction with id '{id}' not found");
            }
        }

        public void Update(int id, Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
