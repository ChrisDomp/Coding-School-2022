using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get;  }
        public DateTime TimeStamp { get; set; }
        public String Message_ { get; set; }// to avoid the conflict with the name of the class
        public Message()
        {
            Message_ =  String.Empty;
            ID = Guid.NewGuid();
        }
      
    }
}
