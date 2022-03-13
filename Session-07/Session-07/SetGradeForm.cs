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
    public partial class SetGradeForm : Form
    {
        private Professor __selectedProfessor;
        private List<Course> Courses;
        public SetGradeForm(ProfessorsManager professorM)
        {
            InitializeComponent();
            __selectedProfessor = professorM.SelectedProfessor;
            Courses = new List<Course>();
            Courses = __selectedProfessor.Courses;
            Show();
            
        }
    }
}
