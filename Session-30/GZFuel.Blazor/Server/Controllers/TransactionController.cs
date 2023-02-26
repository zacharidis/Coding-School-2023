using GZFuel.Blazor.Shared.DTO.Transaction;
using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using GZFuel.Model.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace GZFuel.Blazor.Server.Controllers
{
	[Route("[controller]")]
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
				CustomerID = x.CustomerID,
				EmployeeID = x.EmployeeID,
			});
		}











		//get specific transaction
		[HttpGet("{id}")]

		public async Task <IEnumerable<TransactionDTO>> GetById(int id)
		{
			var result = _transactionRepo.GetAll().Where(x => x.CustomerID == id);

			return result.Select(x => new TransactionDTO
			{
				Date = x.Date,
				ID = x.ID,
				PaymentMethod = x.PaymentMethod,
				TotalValue = x.TotalValue,
				CustomerID = x.CustomerID,
				EmployeeID = x.EmployeeID,
		
			});

			
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

		public async Task Post(TransactionEditDTO transaction , List<TransactionLine> transactionLines)
		{

			var newTransaction = new Transaction
			{

				PaymentMethod = transaction.PaymentMethod,


				CustomerID = transaction.CustomerID,
				EmployeeID = transaction.EmployeeID,
				Date = transaction.Date,
				TotalValue = transaction.TotalValue,
				
		};

			newTransaction.TransactionLines = new List<TransactionLine>();

			foreach (var item in transactionLines)
			{
				newTransaction.TransactionLines.Add(new TransactionLine(item.Quantity ,item.ItemPrice ,item.TotalValue,item.DiscountPercent,item.DiscountValue)
				{
					ItemID = item.ItemID,
					Quantity = item.Quantity,
					ItemPrice = item.ItemPrice,
					TransactionID = item.TransactionID,
					TotalValue = item.TotalValue
				});
				
			}




			_transactionRepo.Add(newTransaction);
		}

		// delete a transaction
		[HttpDelete("{id}")]

		public async Task Delete(int id)
		{
			_transactionRepo.Delete(id);
		}


	}
}
