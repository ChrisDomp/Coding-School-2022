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
        StudentsManager _studentsManager = new StudentsManager();
        Student __selectedStudent = new Student();
        public StudentCoursesForm(StudentsManager studentsManager)
        {
            InitializeComponent();
            _studentsManager = studentsManager;
            __selectedStudent = studentsManager.SelectedStudent;


        }

        private void StudentCourses_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void ShowList()
        {
            listBoxControl1.Items.Clear();
            if (__selectedStudent != null)
            {

                foreach (var item in __selectedStudent.Courses)
                { 

                    if (item != null)
                    listBoxControl1.Items.Add(string.Format("{0}", item.Subject));
                }
            }
        }
    }
}
