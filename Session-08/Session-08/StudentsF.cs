using Session_08_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_08
{
    public partial class StudentsF : Form
    {
        public const string FILE_NAME = "storage.json";
        private List<Student> _students = new List<Student>();
        public StudentsF()
        {
            InitializeComponent();

            if (File.Exists("storage.json"))
            {
                LoadData();
            }


            private void LoadData()
            {
                string s = File.ReadAllText("storage.json");
            }


        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
        internal void Load()
        {

            string s = File.ReadAllText(FILE_NAME);
            _students = JsonSerializer.Deserialize<List<Student>>(s);
            MessageBox.Show("Loaded Students OK!");

        }
        internal void Save()
        {
            string json = JsonSerializer.Serialize(_students);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("File Saved!");
        }

    }
}
