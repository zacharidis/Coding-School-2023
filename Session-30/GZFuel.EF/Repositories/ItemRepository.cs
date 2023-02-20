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
    public class ItemRepository : IEntityRepo<Item>
    {
        public void Add(Item entity)
        {
            using var ctx = new FuelDbContext();
            if (entity.ID == 0) {
                
                throw new ArgumentException("Item cannot have a predefined ID", nameof(entity));
            } else
            {
                ctx.Items.Add(entity);
                ctx.SaveChanges();
            }
                
            
        }

        public void Delete(int id)
        {
            using var ctx = new FuelDbContext();
            var selectedItem = ctx.Items
                .Where(i => i.ID == id)
                .SingleOrDefault();
            if (selectedItem != null)
            {
                ctx.Items.Remove(selectedItem);
                ctx.SaveChanges();
            } else
            {
                throw new KeyNotFoundException($"Item with id '{id}' not found");
            }
        }

        public IEnumerable<Item> GetAll()
        {
            using var ctx = new FuelDbContext();
            var allItems = ctx.Items
                .ToList();
            return allItems;
        }

        public Item? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
