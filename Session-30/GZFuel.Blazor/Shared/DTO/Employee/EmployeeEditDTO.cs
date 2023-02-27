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
		[Required(ErrorMessage = "Please enter a Name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter a Surname")]
		public string Surname { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }

		[Required(ErrorMessage = "Please enter a Salary")]
		public int SalaryPerMonth { get; set; }
		[Required(ErrorMessage = "Please Choose the Employee Type ")]
		public EmployeeType EmployeeType { get; set; }

        public EmployeeEditDTO() { }
    }
}
