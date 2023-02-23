using GZFuel.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Employee
{
    public class EmployeeEditDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public EmployeeEditDTO() { }
    }
}
