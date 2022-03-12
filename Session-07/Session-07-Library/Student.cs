using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    [Serializable]
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public Student()
        {
           RegistrationNumber = 0;
           //Courses.Add()

           //Courses = null;    
        }
        public void Attend(Course course, DateTime dateTime)
        {
            //TODO
        }
        public void WriteExam(Course course, DateTime dateTime)
        {
            //TODO
        }


    }
}