using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }
        public University()
        { Student[] students = new Student[30];
          Professor[] professors = new Professor[5];
          Course[] courses = new Course[20];
          Schedule[] schedules = new Schedule[60];
        }
        public Student[] GetStudents(){
            return Students;
        }
        public Course[] GetCourses()
        {
            return Courses;
        }
        public Grade[] GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime dateTime)
        { 
         //TODO
        }
    }
}
