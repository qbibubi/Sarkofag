using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



        }
    }
}
