using Fuel_Station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Blazor.Shared
{
    public class ItemListViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public ItemListViewModel()
        {
            Id = Guid.NewGuid();
            Code = Guid.NewGuid().ToString();
        }

    }
    public class ItemEditViewModel
    {
        public Guid Id { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public ItemEditViewModel()
        {
            Id = Guid.NewGuid();
            Code = Guid.NewGuid().ToString();
        }
    }
}