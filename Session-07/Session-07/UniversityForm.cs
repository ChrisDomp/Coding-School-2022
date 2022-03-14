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
//using Newtonsoft.Json;
using Session_07_Library;
namespace Session_07
{
    public partial class UniversityForm : Form
    {

        public UniversityForm()
        {
            InitializeComponent();
  
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form studentsForm = new StudentsForm();
 
            studentsForm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form professorForm = new ProfessorsForm();
            professorForm.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form sheduleForm = new SheduleForm();
            sheduleForm.Show();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form gradesForm = new GradesForm();
            gradesForm.Show();
        }

        private void editToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form courseForm = new CourseForm();
            courseForm.Show();
        }
    }
}
