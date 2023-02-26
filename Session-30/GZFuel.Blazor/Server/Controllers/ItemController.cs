using GZFuel.Blazor.Shared.DTO.Item;
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
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                ItemType = x.ItemType,
                Price = x.Price,
                Cost = x.Cost
            });
            
        }


        // create new item 
        [HttpPost]
        public async Task Post(ItemDTO item)
        {
            var newItem = new Item () 
            
            
            { Code = item.Code, Cost = item.Cost, Description = item.Description, ItemType = item.ItemType,
                Price = item.Price
            
            
            };
            _itemRepo.Add(newItem);
            

        }


		[HttpDelete("{id}")]

		public async Task Delete(int id)
		{
			_itemRepo.Delete(id);
		}

	}
}
