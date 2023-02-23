using GZFuel.Blazor.Shared.DTO.Employee;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
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






    }
}
