using GZFuel.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Employee
{
    public class EmployeeEditDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        
        [Required]
		public int SalaryPerMonth { get; set; }
        [Required]
		public EmployeeType EmployeeType { get; set; }

        public EmployeeEditDTO() { }
    }
}
