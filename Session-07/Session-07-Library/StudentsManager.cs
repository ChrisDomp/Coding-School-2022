using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Session_07_Library
{      [Serializable]
    public class StudentsManager : ObjectManager
    {
        public const string FILE_NAME = "students.json";
        public List<Student> Students { get; set; }
        public Student SelectedStudent { get; set; }

        public StudentsManager()
        {
            Students = new List<Student>();
            SelectedStudent = null;
        }
        public void Populate()
        {
            var Chris = new Student()
            {
                Age = 21,
                Name = "Chris Domp",
                RegistrationNumber = 7677
            };
            Students.Add(Chris);
            Students.Add(Chris);
            Students.Add(Chris);
            Students.Add(Chris);
            Students.Add(Chris);
            Students.Add(Chris);


        }
        public void Save()
        {
            string json = JsonSerializer.Serialize(Students);
            File.WriteAllText(FILE_NAME, json);
            MessageBox.Show("File Saved!");
        }
        public void Load()
        {
            string s = File.ReadAllText(FILE_NAME);
            Students = JsonSerializer.Deserialize<List<Student>>(s);

            MessageBox.Show("Loaded students successfully!");

        }
        public void Delete()
        {
            Students.Remove(SelectedStudent);
            
        }
       public void Update(string name,int age,int regNum)
        {
            if (SelectedStudent != null) 
            { 
            SelectedStudent.Name = name;
            SelectedStudent.Age = age;
            SelectedStudent.RegistrationNumber = regNum;
            //SelectedStudent.Course
            }
        }
       public void Create()
        {
            var stud = new Student();
            Students.Add(stud);
            
        }

    }
}
