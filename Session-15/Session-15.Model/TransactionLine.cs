using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.Model
{
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ServiceTaskID { get; set; }
        public Guid EngineerID { get; set; }
        public decimal Hours { get; set; }
        public decimal PRICE_PER_HOUR { get; } = 44.5m;
        public decimal Price { get; set; }
        //public Transaction Transaction { get; set; }

        public TransactionLine()
        {
            
        }
    }
}
