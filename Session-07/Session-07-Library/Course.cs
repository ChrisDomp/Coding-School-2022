using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public class Course
    {
        public Guid ID { get;  }
        public String Code { get; set; }
        public String Subject { get; set; }
        public Course()
        {
            ID = Guid.NewGuid();
            Code = String.Empty;
            Subject = String.Empty;
        }
    }
}
