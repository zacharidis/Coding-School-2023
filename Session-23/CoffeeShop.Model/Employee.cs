using CoffeeShop.Model.Enums;

namespace CoffeeShop.Model
{
    public class Employee
    {
        public Employee(string name, string surname, int salaryPerMonth, EmployeeType employeeType)
        {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
