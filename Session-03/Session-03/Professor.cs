using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person{
        public String Rank { get; set; }

        public Course[] Courses { get; set; }
        public Professor()
        {
            ID = Guid.NewGuid();
            Rank = "None";
        }
        public void Teach(Course course, DateTime dateTime)
        {
           //TODO:
        }
        public void SetGrade(Guid studentID,Guid courseID,int grade)
        {
           //TODO
        }
        
        public String GetName()
        {
            return "Dr." + Name;
        }
      }
}
