using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int Grade_ { get; set; }
        public Grade()
        {
            ID = Guid.NewGuid();
            StudentId = Guid.NewGuid();
            CourseId = Guid.NewGuid();
        }
    }
}
