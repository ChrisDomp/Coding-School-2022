using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Library
{
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }
        public University()
        {

        }
        public List<Student> GetStudents()
        {
            return Students;
        }
        public List<Course> GetCourses()
        {
            return Courses;
        }
        public List<Grade> GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime dateTime)
        {
            //TODO
        }
    }
}
