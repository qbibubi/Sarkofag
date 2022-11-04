using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretariat
{
    public partial class AddStudent : UserControl
    {
        public class Student
        {
            public string StudentName { get; set; }
            public string StudentLastName { get; set; }
            public string StudentClass { get; set; }
        }

        public List<Student> students;
        public string path = @"C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\dane.txt";

        public AddStudent()
        {
            InitializeComponent();
            students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(path));
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentName = firstNameInput.Text,
                StudentLastName = lastNameInput.Text,
                StudentClass = classInput.Text
            };

            students.Add(student);
            File.WriteAllText(path, JsonSerializer.Serialize(students));
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var StudentInfo = studentName.Text;
            var SearchInfo = startsWith.Text;
            var SearchBarText = searchInput.Text;
            List<string> strings;

            switch (StudentInfo)
            {
                case "Imię":
                    strings = students.Select(x => x.StudentName).ToList();
                    break;
                case "Nazwisko":
                    strings = students.Select(x => x.StudentLastName).ToList();
                    break;
                case "Klasa":
                    strings = students.Select(x => x.StudentClass).ToList();
                    break;
                default:
                    return;
            }

            var outcome = "";
            switch (SearchInfo)
            {
                case "równe":
                    outcome = strings.Find(x => x.Equals(SearchBarText));
                    break;
                case "rozpoczyna się od":
                    outcome = strings.Find(x => x.StartsWith(SearchBarText));
                    break;
                case "zawiera":
                    outcome = strings.Find(x => x.Contains(SearchBarText));
                    break;
                default:
                    return;
            }
        }
    }
}
