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

		public async Task<IEnumerable<CustomerDTO>> Get()
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
			var newCustomer = new Customer
			{

				Name = customer.Name,
				Surname = customer.Surname,
				CardNumber = customer.CardNumber

			};

			newCustomer.Transactions = new();

			_customerRepo.Add(newCustomer);

		}



		// update a specific customer 

		[HttpPut]
		public async Task Put(CustomerEditDTO customer)
		{
			var result = _customerRepo.GetById(customer.Id);
			result.Name = customer.Name;
			result.Surname = customer.Surname;
			result.CardNumber = customer.CardNumber;
			_customerRepo.Update(customer.Id, result);


		}


		// delete a customer 
		[HttpDelete("{id}")]

		public async Task Delete(int id)
		{
			_customerRepo.Delete(id);
		}










	}

	}

