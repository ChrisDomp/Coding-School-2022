namespace Session_08_Library
{

        [Serializable]
        public class Student : Person
        {
            public int RegistrationNumber { get; set; }
            public List<Course> Courses { get; set; }
            public Student()
            {
                RegistrationNumber = 0;
                Courses = new List<Course>();
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