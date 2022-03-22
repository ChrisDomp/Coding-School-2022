using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_08_Library
{
    public class Person
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            ID = Guid.NewGuid();
            Name = "New Name";
            Age = 0;
        }
    }
}
