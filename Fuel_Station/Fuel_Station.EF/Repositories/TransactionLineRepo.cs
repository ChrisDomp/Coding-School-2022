using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Context;
using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.EF.Repositories
{

    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly ApplicationContext _context;
        public TransactionLineRepo(ApplicationContext dbCOntext)
        {
            _context = dbCOntext;
        }
        public async Task CreateAsync(TransactionLine entity)
        {
            //if (entity.ID != Guid.Empty)
            //    throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            _context.TransactionLines.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundTransactionLine = _context.TransactionLines.SingleOrDefault(trLines => trLines.ID == id);
            if (foundTransactionLine is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            _context.TransactionLines.Remove(foundTransactionLine);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            return await _context.TransactionLines.ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id)
        {
            return await _context.TransactionLines.SingleOrDefaultAsync(trLines => trLines.ID == id);
        }

     

        public async Task UpdateAsync(Guid id, TransactionLine entity)
        {
            var foundTransactionLine = _context.TransactionLines.SingleOrDefault(rrLines => rrLines.ID == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.TotalValue = entity.TotalValue;
            foundTransactionLine.NetValue = entity.NetValue;
            foundTransactionLine.DiscountValue = entity.DiscountValue;
            foundTransactionLine.DiscountPercent = entity.DiscountPercent;
            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.ItemPrice = entity.ItemPrice;
            //itemid??

            await _context.SaveChangesAsync();
        }
    }
}

