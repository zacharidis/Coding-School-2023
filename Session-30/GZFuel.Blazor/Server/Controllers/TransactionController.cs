using GZFuel.Blazor.Shared.DTO.Transaction;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionController : ControllerBase
	{

		private readonly IEntityRepo<Transaction> _transactionRepo;

		public TransactionController(IEntityRepo<Transaction> transactionRepo)
		{
            _transactionRepo = transactionRepo;
        }


		[HttpGet]
		public async Task <IEnumerable<TransactionDTO>> Get()
		{

			var result = _transactionRepo.GetAll();

			return result.Select(x => new TransactionDTO
			{
				Date = x.Date,
				ID = x.ID,
				PaymentMethod = x.PaymentMethod,
				TotalValue = x.TotalValue,
			});
		}


		//get specific transaction
		[HttpGet("{id}")]

		public async Task <TransactionEditDTO> GetById(int id)
		{
			var result = _transactionRepo.GetById(id);

			return new TransactionEditDTO
			{
				ID = result.ID,
				PaymentMethod = result.PaymentMethod,
				TotalValue = result.TotalValue,
				CustomerID = result.CustomerID,
				EmployeeID = result.EmployeeID,
				Date = result.Date,

			};
		}


		//update a transaction 

		[HttpPut]
		public async Task Put(TransactionEditDTO transaction)
		{
			var result = _transactionRepo.GetById(transaction.ID);
			result.PaymentMethod = transaction.PaymentMethod;
			result.TotalValue = transaction.TotalValue;
			result.EmployeeID = transaction.EmployeeID;
			result.Date = transaction.Date;
			result.CustomerID = transaction.CustomerID;
			_transactionRepo.Update(transaction.ID, result);
		}


		// create new transaction
		[HttpPost]

		public async Task Post(TransactionEditDTO transaction)
		{

			var newTransaction = new Transaction
			{
				ID = transaction.ID,
				PaymentMethod = transaction.PaymentMethod,

				TotalValue = transaction.TotalValue,
				CustomerID = transaction.CustomerID,
				EmployeeID = transaction.EmployeeID,
				Date = transaction.Date,
				PaymentMethod = transaction.PaymentMethod
			};


		}




	}
}
