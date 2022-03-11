using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public class Schedule
    {
        public Guid ID { get;  }
        public Guid CourseID { get;  }
        public Guid ProfessorID { get;  }
        public DateTime Calendar { get; set; }
        public Schedule()
        {
            ID = Guid.NewGuid();
            CourseID = Guid.NewGuid();
            ProfessorID = Guid.NewGuid();

        }
    }
}
