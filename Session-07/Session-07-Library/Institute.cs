using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public class Institute
    {
        public Guid ID { get; }
        public String Name { get; set; }
        public int YearsInService { get; set; }

        private string _name;
        public Institute()
        {
            ID = Guid.NewGuid();
            Name = String.Empty;
            YearsInService = 0;
        }
        
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
