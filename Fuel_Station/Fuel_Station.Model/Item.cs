using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.Model
{
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Item()
        {
            ID = Guid.NewGuid();
            Code = Guid.NewGuid().ToString();
        }

    }
}
