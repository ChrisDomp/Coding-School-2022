using Session_07_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{

    public partial class StudentCoursesForm : Form
    {
        StudentsManager studentsManager = new StudentsManager();
        Student _selectedStudent = new Student();
        public StudentCoursesForm(StudentsManager Manager)
        {
            InitializeComponent();
            studentsManager = Manager;
            _selectedStudent = studentsManager.SelectedStudent;


        }

        private void StudentCourses_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void ShowList()
        {
            listBoxControl1.Items.Clear();
            if (_selectedStudent != null)
            {

                foreach (var item in _selectedStudent.Courses)
                { 

                    if (item != null)
                    listBoxControl1.Items.Add(string.Format("{0}", item.Subject));
                }
            }
        }
    }
}
