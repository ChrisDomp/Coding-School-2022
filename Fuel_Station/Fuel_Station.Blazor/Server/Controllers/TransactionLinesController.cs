using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fuel_Station.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionLinesController : ControllerBase
    {
        private readonly IEntityRepo<TransactionLine> _transactionLinesRepo;

        public TransactionLinesController(IEntityRepo<TransactionLine> transactionLinesRepo)
        {
            _transactionLinesRepo = transactionLinesRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionLineListViewModel>> Get()
        {
            var result = await _transactionLinesRepo.GetAllAsync();
            return result.Select(x => new TransactionLineListViewModel
            {
                Id = x.ID,
                Quantity = x.Quantity,
                ItemID = x.ItemID,
                DiscountPercent = x.DiscountPercent,
                NetValue = x.NetValue,
                TotalValue = x.TotalValue,
                TransactionID = x.TransactionID,
                DiscountValue = x.DiscountValue,
                ItemPrice = x.ItemPrice,
            });
        }

        [HttpPost]
        public async Task Post(TransactionLineListViewModel transactionLine)
        {
            var newTransactionLine = new TransactionLine()
            {
                ID = transactionLine.Id,
                Quantity = transactionLine.Quantity,
                ItemPrice = transactionLine.ItemPrice,
                DiscountPercent = transactionLine.DiscountPercent,
                NetValue = transactionLine.NetValue,
                TotalValue = transactionLine.TotalValue,
                TransactionID = transactionLine.TransactionID,
                ItemID = transactionLine.ItemID,
                DiscountValue = transactionLine.DiscountValue

            };


            await _transactionLinesRepo.CreateAsync(newTransactionLine);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionLinesRepo.DeleteAsync(id);
        }

    }
}
