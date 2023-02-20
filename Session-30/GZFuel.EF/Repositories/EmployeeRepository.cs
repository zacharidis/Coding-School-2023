using GZFuel.EF.Context;
using GZFuel.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Repositories
{
    public class EmployeeRepository : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var ctx = new FuelDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Employee cannot have a predefined ID");
            }
            else
            {
                ctx.Employees.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
