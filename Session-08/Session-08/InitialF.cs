using Session_08_Library;
using System.IO;
using System.Text.Json;

namespace Session_08
{

    public partial class InitialF : Form
    {
        public const string FILE_NAME = "storage.json";
        public List<Student> _students { get; set; }
        public InitialF()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new StudentsF();
            f1.Show();
        }
    }

}