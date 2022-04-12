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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly ApplicationContext _context;
        public EmployeeRepo(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public async Task CreateAsync(Employee entity)
        {
            //if (entity.ID != Guid.Empty)
            //    throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Guid id)
        {
            var foundEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            _context.Employees.Remove(foundEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await _context.Employees.SingleOrDefaultAsync(mployee => mployee.ID == id);

        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            var foundEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.SalaryPerMonth= entity.SalaryPerMonth;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            foundEmployee.EmployeeType = entity.EmployeeType;


            await _context.SaveChangesAsync();
        }
    }
}
