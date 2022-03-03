using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public int YearsInService { get; set; }
        public Institute()
        {
            ID = Guid.NewGuid();
            Name = "None";
            YearsInService = 0;
        }
        private string _name;
        public String GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
    }
}
