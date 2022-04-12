using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fuel_Station.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeListViewModel
            {
                Id = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                SalaryPerMonth = x.SalaryPerMonth,
                HireDateEnd = x.HireDateEnd,
                HireDateStart = x.HireDateStart,
                EmployeeType  = x.EmployeeType,              

            });
        }
        [HttpGet("{id}")]
        public async Task<EmployeeEditViewModel> Get(Guid id)
        {
            EmployeeEditViewModel model = new();
            if (id != Guid.Empty)//danger!!
            {
                var existing = await _employeeRepo.GetByIdAsync(id);
                model.Id = existing.ID;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.EmployeeType = existing.EmployeeType;
                model.SalaryPerMonth = existing.SalaryPerMonth;
                model.HireDateEnd = existing.HireDateEnd;
                model.HireDateStart = existing.HireDateStart;

            }

            return model;
        }
        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee)
        {
            var newEmployee = new Employee()
            {
                ID = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth = employee.SalaryPerMonth,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,

            };


            await _employeeRepo.CreateAsync(newEmployee);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _employeeRepo.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel employee)
        {
            var itemToUpdate = await _employeeRepo.GetByIdAsync(employee.Id);
            if (itemToUpdate == null) return NotFound();
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.EmployeeType = employee.EmployeeType;

            await _employeeRepo.UpdateAsync(employee.Id, itemToUpdate);

            return Ok();
        }
    }
}
