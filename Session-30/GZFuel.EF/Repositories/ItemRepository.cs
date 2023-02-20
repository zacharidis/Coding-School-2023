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
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
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
