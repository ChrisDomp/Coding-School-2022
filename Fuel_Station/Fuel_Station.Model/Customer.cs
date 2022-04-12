using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Model
{
    public class Customer : Person
    {
        public  string CardNumber { get; set; }
        //public Transaction Transaction { get; set; }

        public Customer()
        {
            ID = Guid.NewGuid();
            CardNumber = 'A' + Guid.NewGuid().ToString();
        }
    }
}
