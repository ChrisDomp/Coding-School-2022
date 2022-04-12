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
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly ApplicationContext _context;
        public CustomerRepo(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public async Task CreateAsync(Customer entity)
        {
            //if (entity.ID != Guid.Empty)
            //    throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Guid id)
        {
            var foundCustomer = _context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            _context.Customers.Remove(foundCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);

        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            var foundCustomer = _context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            //foundCustomer.CardNumber = entity.CardNumber;
            

            await _context.SaveChangesAsync();
        }
    }
}
