using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Model
{
    public class Employee : Person
    {
        public DateTime? HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //Νavigation property
        public Transaction? Transaction { get; set; }

        public Employee()
        {
            ID = Guid.NewGuid();
        }
    }
}
