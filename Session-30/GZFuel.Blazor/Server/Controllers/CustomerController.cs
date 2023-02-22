using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GZFuel.Blazor.Shared.DTO.Customer;

namespace GZFuel.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{


		private readonly IEntityRepo<Customer> _customerRepo;

		public CustomerController(IEntityRepo<Customer> customerRepo)
		{
			_customerRepo = customerRepo;
		}


		// Get all the customers from repo 

		[HttpGet]
		
		public async Task <IEnumerable<CustomerDTO>> Get()
		{

			var result = _customerRepo.GetAll();
			return result.Select(x => new CustomerDTO
			{
				Id = x.ID,
				Name = x.Name,
				Surname = x.Surname,
				CardNumber = x.CardNumber
			});
				
			
		}


	







	}
}
