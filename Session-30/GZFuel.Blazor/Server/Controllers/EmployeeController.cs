using GZFuel.Blazor.Shared.DTO.Employee;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        //Get all the employees 

        [HttpGet]
        public async Task<IEnumerable<EmployeeDTO>> Get()
        {
            var result = _employeeRepo.GetAll();
            return result.Select(x => new EmployeeDTO
            {
                EmployeeType
                = x.EmployeeType,
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd,
                SalaryPerMonth = x.SalaryPerMonth,

            });
        }

        //Get a single Employee for his details page 
        [HttpGet("{id}")]
        public async Task <EmployeeEditDTO> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);

            return new EmployeeEditDTO
            {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateEnd = result.HireDateEnd,
                EmployeeType = result.EmployeeType,
                SalaryPerMonth = result.SalaryPerMonth,
                HireDateStart = result.HireDateStart,
            };
        }

        //create new emp

        [HttpPost]
        public async Task Post(EmployeeEditDTO employee)
        {
			var newEmployee = new Employee (employee.Name , employee.Surname , employee.SalaryPerMonth,employee.EmployeeType)
            {
				Name = employee.Name,
				Surname = employee.Surname,
				HireDateStart = employee.HireDateStart,
				HireDateEnd = employee.HireDateEnd,
				SalaryPerMonth = employee.SalaryPerMonth,
				EmployeeType = employee.EmployeeType,
			};
			_employeeRepo.Add(newEmployee);
		}


        [HttpPut]
        public async Task Put(EmployeeEditDTO employee)
        {

            var dbEmployee = _employeeRepo.GetById(employee.Id);
                dbEmployee.Name = employee.Name;
                dbEmployee.Surname = employee.Surname;
                dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
                dbEmployee.HireDateStart = employee.HireDateStart;
                dbEmployee.HireDateEnd = employee.HireDateEnd;
                _employeeRepo.Update(employee.Id, dbEmployee);




        }

        [HttpDelete("{id}")]

        public async Task Delete(int id)
        {
            _employeeRepo.Delete(id);
        }


    }
}
