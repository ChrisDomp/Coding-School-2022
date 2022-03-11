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
       // private University _university;
        public const string FILE_NAME = "students.json";

        public List<Student> _students;
        private Student _selectedStudent ;

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
            //_university = new University();
           
            CreateStudents();
  
            LoadStudentData();
            ShowList();
            
        }
        private void simpleButtonNew_Click(object sender, EventArgs e)
        {
            CreateStudent();
            ShowList();
        }
        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
            ShowList();
        }
        #endregion


        #region Operations


        private void CreateStudents()
        {
            _students = new List<Student>();

            var Chris = new Student()
            {
                RegistrationNumber = 7677,
                Name = "Chris "
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
            //if(_selectedStudent!=null)
            if(listBoxControl1.SelectedIndex>-1)    //listBoxControl1.SelectedIndex becomes -1 when deleting a student???
                _selectedStudent = _students[listBoxControl1.SelectedIndex];            
        }
        private void ShowList()
        {

            listBoxControl1.Items.Clear();

            foreach (Student item in _students)
            {

                if (item != null)
                    listBoxControl1.Items.Add(string.Format("{0}", item.Name));
            }
        }

        private void DisplayStudent()
        {
            if(_selectedStudent != null)
            {
            textEdit1.Text = _selectedStudent.Name;
            textEdit2.Text = _selectedStudent.Age.ToString();
            textEdit3.Text = _selectedStudent.RegistrationNumber.ToString();
            //textEdit4.Text = _selectedStudent.Courses.ToString();
            }
        }
        #endregion

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            SaveStudentData();
            this.Close();
        }
       
        private void UpdateStudent()
        {
            _selectedStudent.Name = textEdit1.Text;
            _selectedStudent.Age = Convert.ToInt32(textEdit2.Text);
            _selectedStudent.RegistrationNumber= Convert.ToInt32(textEdit3.Text);  
        }


        private void DeleteStudent()
        {
            _students.Remove(_selectedStudent);
            if(_students.Count()>0)
            _selectedStudent = _students[0];

        }
        
        private void CreateStudent()
        {
            var stud = new Student();
            _students.Add(stud);
            listBoxControl1.SelectedIndex = _students.Count();
        }

       
    }
}
     