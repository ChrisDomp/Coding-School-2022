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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly ApplicationContext _context;
        public TransactionRepo(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public async Task CreateAsync(Transaction entity)
        {
            //if (entity.ID != Guid.Empty)
            //    throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            _context.Transactions.Add(entity);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteAsync(Guid id)
        {
            var foundTransaction = _context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            _context.Transactions.Remove(foundTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);

        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            var foundTransaction = _context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;

            foundTransaction.TotalValue = entity.TotalValue;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.Date = entity.Date;
            //foundTransaction.EmployeeID = entity.EmployeeID;
            //foundTransaction.CostumerID = entity.CostumerID;



            await _context.SaveChangesAsync();
        }

    }
    
}
