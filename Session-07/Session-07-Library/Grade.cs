using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public class Grade
    {
        public Guid ID { get; }
        public Guid StudentId { get; }
        public Guid CourseId { get; }
        public int Value { get; set; }
        public Grade()
        {
            ID = Guid.NewGuid();
            StudentId = Guid.NewGuid();
            CourseId = Guid.NewGuid();
        }
    }
}
