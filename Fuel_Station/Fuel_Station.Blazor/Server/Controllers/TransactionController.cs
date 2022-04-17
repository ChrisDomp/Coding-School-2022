using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fuel_Station.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionListViewModel
            {
                Id = x.ID,
                CustomerID = x.CustomerID,
                EmployeeID = x.EmployeeID,
                Date = x.Date,
                PaymentMethod = x.PaymentMethod,
                TotalValue = x.TotalValue                
            });
        }
        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(Guid id)
        {
            TransactionEditViewModel model = new();
            if (id != Guid.Empty)//danger!!
            {
                var existing = await _transactionRepo.GetByIdAsync(id);
                model.Id = existing.ID;
                model.CustomerID = existing.CustomerID;
                model.EmployeeID = existing.EmployeeID;
                model.Date = existing.Date;
                model.PaymentMethod = existing.PaymentMethod;
                model.TotalValue = existing.TotalValue;
                          

            }

            return model;
        }
        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction)
        {
            var newTransaction = new Transaction()
            {
                ID = transaction.Id,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue

            };


            await _transactionRepo.CreateAsync(newTransaction);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionRepo.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction)
        {
            var itemToUpdate = await _transactionRepo.GetByIdAsync(transaction.Id);
            if (itemToUpdate == null) return NotFound();
            itemToUpdate.CustomerID = transaction.CustomerID;
            itemToUpdate.EmployeeID = transaction.EmployeeID;
            itemToUpdate.Date = transaction.Date;
            itemToUpdate.PaymentMethod = transaction.PaymentMethod;
            itemToUpdate.TotalValue = transaction.TotalValue;


            await _transactionRepo.UpdateAsync(transaction.Id, itemToUpdate);

            return Ok();
        }
    }
}
