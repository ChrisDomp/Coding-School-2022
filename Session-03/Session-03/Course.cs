using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        public Guid ID { get; set; }
        public String Code { get; set; }
        public String Subject { get; set; }
        public Course()
        {
            ID = Guid.NewGuid();
            Code = "None";
            Subject = "None";
        }
    }
}
