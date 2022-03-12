using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session_07_Library;

namespace Session_07
{
    public partial class ProfessorsForm : Form
    {
        private List<Professor> _professors;
        private Professor _selectedProfessor;
        private ProfessorsManager professorsManager;

        #region UI
        public ProfessorsForm()
        {
            InitializeComponent();
        }

        private void simpleCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProfessor();
            DisplayProfessor();
        }

        

        private void ProfessorsForm_Load(object sender, EventArgs e)
        {
            professorsManager = new ProfessorsManager();
            professorsManager.Load();
            _professors = professorsManager.Professors;
            _selectedProfessor = professorsManager.SelectedProfessor;
            ShowList();
        }
 
       

        private void simpleButtonNew_Click(object sender, EventArgs e)
        {
            professorsManager.Create();
            ShowList();
            DisplayProfessor();

        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            professorsManager.Update(textName.Text, Convert.ToInt32(textAge.Text), textRank.Text);
            professorsManager.Save();
            this.Close();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            professorsManager.Delete();
            ShowList();
        }
        #endregion
        private void ShowList()
        {

            listBoxControl1.Items.Clear();

            foreach (Professor item in _professors)
            {

                if (item != null)
                    listBoxControl1.Items.Add(string.Format("{0}", item.Name));
            }
        }
        private void DisplayProfessor()
        {
            if (_selectedProfessor != null)
            {
                textName.Text = _selectedProfessor.Name;
                textAge.Text = _selectedProfessor.Age.ToString();
                textRank.Text = _selectedProfessor.Rank;

            }
        }
        private void SelectProfessor()
        {
            //if(_selectedStudent!=null)
            if (listBoxControl1.SelectedIndex != -1)//listBoxControl1.SelectedIndex becomes -1 when deleting a student???
                _selectedProfessor = _professors[listBoxControl1.SelectedIndex];
        }
    }
}
