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
    public class TransactionLineRepository : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var ctx = new FuelDbContext();
            if (entity.ID != 0)
            {
                ctx.Add(entity);
            }
            else
            {
                throw new ArgumentException(" A TransactionLine cannot have a predefined ID", nameof(entity));

            }
        }

        public void Delete(int id)
        {
            using var ctx = new FuelDbContext();
            var dbTransactionLine = ctx.TransactionsLines.SingleOrDefault(tl => tl.ID == id);
            if (dbTransactionLine != null)
            {
                ctx.TransactionsLines.Remove(dbTransactionLine);
                ctx.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"A Transaction with id '{id}' was not found");
            }

        }

        public IEnumerable<TransactionLine> GetAll()
        {
            using var ctx = new FuelDbContext();
            return ctx.TransactionsLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var ctx = new FuelDbContext();
            var selectedTl = ctx.TransactionsLines.Where(tl => tl.ID == id).SingleOrDefault();
            if (selectedTl != null)
            {
                return selectedTl;
            }
            else
            {
                throw new KeyNotFoundException($"a transaction line with id : {id} was not found");
            }
        } 

            public void Update(int id, TransactionLine entity)
            {
                using var ctx = new FuelDbContext();
                var dbTransactionLine = ctx.TransactionsLines.Where(tl=> tl.ID == id).SingleOrDefault();    
               if (dbTransactionLine != null)
            {
                dbTransactionLine.NetValue = entity.NetValue;
                dbTransactionLine.TotalValue = entity.TotalValue;
                dbTransactionLine.Quantity = entity.Quantity;
                ctx.SaveChanges();
                //todo : NOT FINISHED 
            }
            }


        }
    } 

