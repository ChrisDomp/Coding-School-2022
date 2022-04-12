using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Blazor.Shared
{
    public class CustomerListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        public CustomerListViewModel()
        {
            Id = Guid.NewGuid();
            CardNumber = 'A' + Guid.NewGuid().ToString();
        }
    }
    public class CustomerEditViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
        public CustomerEditViewModel()
        {
            Id = Guid.NewGuid();
            CardNumber = 'A' + Guid.NewGuid().ToString();

        }
    }
}
