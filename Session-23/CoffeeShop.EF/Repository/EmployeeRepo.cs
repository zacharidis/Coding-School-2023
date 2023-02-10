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
            throw new NotImplementedException();
        }

        public void Delete(int id, Employee entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
