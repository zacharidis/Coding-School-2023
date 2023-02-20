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
            using var ctx = new FuelDbContext();
            //go get the specific Employee
            var dbEmployee = ctx.Employees
                .Where(e => e.Id == id)
                .SingleOrDefault();
            if (dbEmployee != null)
            {
                ctx.Employees.Remove(dbEmployee);
                ctx.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Employee with id '{id}' not found");
            }
        } 



        public IEnumerable<Employee> GetAll()
        {
            using var ctx = new FuelDbContext();

            var dbEmployee = ctx.Employees
                .Include(e => e.Transactions).ToList();
            return dbEmployee;
            
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
