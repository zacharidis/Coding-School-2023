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
		// all controllers should have a repo 
		// and a constructor to inject the repo
		// so we have a Get method to get all the customers
		// and a Get method to get a customer by id
		//TODO  and we have a Post method to create a new customer
		//TODO  and we have a Put method to update a customer
		//TODO  and we have a Delete method to delete a customer

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


		// Get customer by id

		[HttpGet("{id}")]
		public async Task<CustomerEditDTO> GetById(int id)
		{

		 var result = _customerRepo.GetById(id);
		
		

				return new CustomerEditDTO
				{
					Id = result.ID,
					Name = result.Name,
					Surname = result.Surname,
					CardNumber = result.CardNumber
				};
			}



		// Create a new Customer


		[HttpPost]
		public async Task Post(CustomerEditDTO customer)
		{
			var newCustomer  = new Customer
			{
				
				Name = customer.Name,
				Surname = customer.Surname,
				CardNumber = customer.CardNumber
				
			};

			newCustomer.Transactions = new();

			_customerRepo.Add(newCustomer);
			
		}




		

		}

	  
	  







	}

