using Fuel_Station.EF.Context;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.EF.Repository
{
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly ApplicationContext _context;
        public ItemRepo(ApplicationContext dbContext)
        {
            _context = dbContext;
        }
    
        public async Task CreateAsync(Item entity)
        {
           
            _context.Items.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundItem = _context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            _context.Items.Remove(foundItem);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await _context.Items.SingleOrDefaultAsync(item => item.ID == id);

        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            var foundItem = _context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                return;

            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;
            foundItem.ItemType = entity.ItemType;

            await _context.SaveChangesAsync();
        }
    }
}
