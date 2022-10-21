using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretariat
{
    public partial class AddStudent : UserControl
    {
        DataHandler conn = new DataHandler();

        public AddStudent()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\dane.txt";

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            // Text file based solution
            var line = classInput.Text + " " + firstNameInput.Text + " " + lastNameInput.Text;
            
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                File.AppendAllLines(path, new[] { line });
            }
            else if (File.Exists(path))
            {
                File.AppendAllLines(path, new[] { line });
            }

            // Database solution

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var choice = startsWith.Text;
            var search = searchInput.Text;
            
            // Text file based solution
            switch (choice)
            {
                case "równe":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if (line.Equals(search))
                        {
                            searchData.Clear();
                            var output = line + System.Environment.NewLine;
                            searchData.Text += output;
                        }
                    }
                    break;
                case "rozpoczyna się od":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if (line.StartsWith(search))
                        {
                            searchData.Clear();
                            var output = line + System.Environment.NewLine;
                            searchData.Text += output;
                        }
                    }
                    break;
                case "zawiera":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if(line.Contains(search))
                        {
                            searchData.Clear();
                            var output = line + System.Environment.NewLine;
                            searchData.Text += output;
                        }
                    }
                    break;
            }
            
            // Database solution

        }
    }
}
