using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GZFuel.Blazor.Shared.DTO.Admin;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;

namespace GZFuel.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IEntityRepo<Admin> _adminRepo;
        public AdminController(IEntityRepo<Admin> adminRepo)
        {

            _adminRepo= adminRepo;


        }
        
        
        [HttpGet]
        public async Task <IEnumerable<AdminDTO>> Get()
        {
            var result = _adminRepo.GetAll();
            return result.Select(x => new AdminDTO
            {
                Id =  x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Username = x.Username,
                Password = x.Password
            });
            
        }
    }
}
