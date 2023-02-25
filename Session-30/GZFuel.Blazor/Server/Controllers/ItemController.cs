using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ItemController : ControllerBase
	{
		private readonly IEntityRepo<Item> _itemRepo;

		public ItemController(IEntityRepo<Item> itemRepo)
		{
            _itemRepo = itemRepo;
        }


		//Get all the items from the repo

		[HttpGet]
		public async Task<IEnumerable<ItemDTO>> Get()
		{
            var result = _itemRepo.GetAll();
            return result.Select(x => new ItemDTO
			{
                Id = x.ID,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity
            });
        }


	}
}
