using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session_07_Library;

namespace Session_07
{
    public partial class StudentsForm : Form
    {

        public const string FILE_NAME = "students.json";//needed for the procedural version

        private List<Student> _students;
        internal Student _selectedStudent; 
        private StudentsManager studentsManager;
        #region UI Controls
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudent();
            DisplayStudent();
           
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            studentsManager = new StudentsManager();
            //studentsManager.Populate();
            studentsManager.Load();
            _students = studentsManager.Students;
            _selectedStudent = studentsManager.SelectedStudent;
            ShowList();
            
        }
        private void simpleButtonNew_Click(object sender, EventArgs e)
        {
            //CreateStudent();
            //var students = new StudentsManager();
            studentsManager.Create();
            ShowList();
            //DisplayStudent();
        }
        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            //DeleteStudent();
            studentsManager.Delete();
            ShowList();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            //UpdateStudent();
            //SaveStudentData();
            studentsManager.Update(textName.Text, Convert.ToInt32(textAge.Text), Convert.ToInt32(textRegNum.Text));
            studentsManager.Save(); 
            this.Close();
        }

        private void simpleButtonEditCourses_Click(object sender, EventArgs e)
        {
            StudentCoursesForm form =  new StudentCoursesForm(studentsManager);
            
            form.Show();
        }


        #endregion


        #region Operations
        private void DisplayStudent()
        {
            if (_selectedStudent != null)
            {
                textName.Text = _selectedStudent.Name;
                textAge.Text = _selectedStudent.Age.ToString();
                textRegNum.Text = _selectedStudent.RegistrationNumber.ToString();
                //textAge.Text = _selectedStudent.Courses.ToString();
            }
        }

        private void CreateStudents()
        {
            _students = new List<Student>();

            var Chris = new Student()
            {
                RegistrationNumber = 7677,
                Name = "Chris ",
                
            };
            var Zina = new Student()
            {
                RegistrationNumber = 7678,
                Name = "Zina "
                
            };
            _students.Add(Chris);
            _students.Add(Zina);
        }

        public void SaveStudentData()
        {

            string json = JsonSerializer.Serialize(_students);

            File.WriteAllText(FILE_NAME, json);

             MessageBox.Show("File Saved!");
        }
        public void LoadStudentData()
        {
            string s = File.ReadAllText(FILE_NAME);
            _students = JsonSerializer.Deserialize<List<Student>>(s);
           
            MessageBox.Show("Loaded Students OK!");
        }
        private void SelectStudent()
        {

            if (listBoxControl1.SelectedIndex != -1)
            { 
                _selectedStudent = _students[listBoxControl1.SelectedIndex];
                studentsManager.SelectedStudent = _selectedStudent;
            }
        }
        private void ShowList()
        {

            listBoxControl1.Items.Clear();

            foreach (Student item in studentsManager.Students)
            {

                if (item != null)
                    listBoxControl1.Items.Add(string.Format("{0}", item.Name));
            }
        }

        private void UpdateStudent()
        {
            _selectedStudent.Name = textName.Text;
            _selectedStudent.Age = Convert.ToInt32(textAge.Text);
            _selectedStudent.RegistrationNumber = Convert.ToInt32(textRegNum.Text);
        }


        private void DeleteStudent()
        {
            _students.Remove(_selectedStudent);
            if (_students.Count() > 0)
                _selectedStudent = _students[_students.Count - 1];

        }

        private void CreateStudent()
        {
            var stud = new Student();
            _students.Add(stud);

        }


        #endregion


    }
}
     