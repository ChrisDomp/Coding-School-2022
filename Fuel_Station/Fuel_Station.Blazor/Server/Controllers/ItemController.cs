using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fuel_Station.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                Id = x.ID,
                Description = x.Description,
                ItemType = x.ItemType,
                Code = x.Code,
                Price = x.Price,
                Cost = x.Cost
            });
        }
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(Guid id)
        {
            ItemEditViewModel model = new();
            if (id != Guid.Empty)//danger!!
            {
                var existing = await _itemRepo.GetByIdAsync(id);
                model.Id = existing.ID;
                model.Description = existing.Description;
                model.ItemType = existing.ItemType;
                model.Code = existing.Code;
                model.Cost = existing.Cost;
                model.Price = existing.Price;
           }

            return model;
        }
        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            var newItem = new Item()
            {
                ID = item.Id,
                Description = item.Description,
                Code = item.Code,
                Cost = item.Cost,
                Price = item.Price,
                ItemType = item.ItemType,

            };


            await _itemRepo.CreateAsync(newItem);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _itemRepo.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.Id);
            if (itemToUpdate == null) return NotFound();
            itemToUpdate.Description = item.Description;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.ItemType = item.ItemType;

            await _itemRepo.UpdateAsync(item.Id, itemToUpdate);

            return Ok();
        }
    }
}
