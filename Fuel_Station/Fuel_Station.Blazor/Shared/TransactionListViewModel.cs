using Fuel_Station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Blazor.Shared
{
    public class TransactionListViewModel
    {
        public Guid Id { get; set; }  
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public TransactionListViewModel()
        {

        }
    }
    public class TransactionEditViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public TransactionEditViewModel()
        {

        }
    }
}
