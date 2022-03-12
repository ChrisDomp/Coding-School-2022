using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace Session_07_Library
{
    public class ProfessorsManager : ObjectManager
    {
        private const string FILE_NAME = "professors.json";
        public List<Professor> Professors { get; set; }
        public Professor SelectedProfessor { get; set; }

        public ProfessorsManager()
        {
            Professors = new List<Professor>();
            SelectedProfessor = null;
        }
        public void Populate() { }
        public void Save()
        {
            string json = JsonSerializer.Serialize(Professors);
            File.WriteAllText(FILE_NAME, json);
            MessageBox.Show("File Saved!");
        }
        public void Load()
        {
            string s = File.ReadAllText(FILE_NAME);
            Professors = JsonSerializer.Deserialize<List<Professor>>(s);

            MessageBox.Show("Loaded professors successfully!");

        }
        public void Delete()
        {
            Professors.Remove(SelectedProfessor);
        }
        public void Update(string name, int age, string rank)
        {
            if (SelectedProfessor != null)
            {
                SelectedProfessor.Name = name;
                SelectedProfessor.Age = age;
                SelectedProfessor.Rank = rank;
                //SelectedStudent.Course
            }
        }
        public void Create()
        {
            var prof = new Professor();
            Professors.Add(prof);
        }

    }
}
