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
    public class AdminRepository : IEntityRepo<Admin>
    {
        // Admin can be only one so we can only update the password here 

        public void Update(int id, Admin entity)
        {
            
        }

        public IEnumerable<Admin> GetAll()
        {
            using var ctx = new FuelDbContext();
            return ctx.Admins.Include(a => a.Password).ToList();
            
        }



        // - unused methods
        public void Add(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       

        public Admin? GetById(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
