using GZFuel.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get;set; }

        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

       // Constructor 
       
        public Employee(string name , string surname , int salaryPerMonth , EmployeeType employeeType)
        {

            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
            Transactions = new List<Transaction>();
        }

        //relationships 

        public List<Transaction> Transactions { get; set; }

    }
}
