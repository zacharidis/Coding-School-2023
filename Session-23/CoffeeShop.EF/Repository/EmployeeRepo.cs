using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new CoffeeShopDbContext();
            int numberOfEmployees = context.Employees.Count();
            if (numberOfEmployees > 0 || numberOfEmployees < 5)
            {
                // restriction for less than 5 employees
               context.Employees.Add(entity);
                context.SaveChanges();

            }
            else
                return;

        }

        public void Delete(int id, Employee entity)
        {
            using var context = new CoffeeShopDbContext();
            var exployeeExists = context.Employees.SingleOrDefault(x => x.Id == id);
            if (exployeeExists == null)
            {
                return;
            } else
            {
                context.Employees.Remove(exployeeExists);
                context.SaveChanges();
            }



        }

        public IEnumerable<Employee> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Employees.Include(Employee =>Employee.Id)
                .Include(Employee => Employee.Name)
                .Include(Employee => Employee.Surname)
                .Include(Employee => Employee.EmployeeType)
                .Include(Employee => Employee.SalaryPerMonth).ToList();

        }

        public Employee? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Employees.Where(Employee=> Employee.Id == id).SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
