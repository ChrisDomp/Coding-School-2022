using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public abstract class ObjectManager
    {
        private List <Object> objects = new List<Object>();
        public ObjectManager()
        {

        }
        //public void Populate() { }
        public void Save() { }
        public void Load() { }
        public void Delete() { }
        public void Update() { }
        //public void Create()
       // {
        //    objects.Add(Object);  
       // }


    }
            
}
