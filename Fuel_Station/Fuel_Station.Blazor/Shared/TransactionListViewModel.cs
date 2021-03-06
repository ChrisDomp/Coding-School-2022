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

        public TransactionListViewModel()
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
            //dummy data in order to make the first store to the db
            EmployeeID = Guid.NewGuid();
            CustomerID = Guid.NewGuid();
            PaymentMethod = (int)PaymentMethod.CreditCard;
            TotalValue = 0;
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


        public TransactionEditViewModel()
        {
            Date = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}
