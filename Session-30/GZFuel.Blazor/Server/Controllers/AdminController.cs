using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GZFuel.Blazor.Shared.DTO.Admin;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;

using System.Collections.Generic;

namespace GZFuel.Blazor.Server.Controllers
{
    [Route("[controller]")]
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



        [HttpGet("{id}")]
        public async Task<AdminEditDTO> GetById(int id)
        {
			var result = _adminRepo.GetById(id);
			return new AdminEditDTO
            {
				Id= result.Id,
				Name = result.Name,
				Surname = result.Surname,
				Username = result.Username,
				Password = result.Password
			};
		}

        //create new

        [HttpPost]
        public async Task Post(AdminEditDTO admin)
        {
			var result = new Admin
            {
				
				Name = admin.Name,
				Surname = admin.Surname,
				Username = admin.Username,
				Password = admin.Password
			};
			_adminRepo.Add(result);
            
        }


    }
}
