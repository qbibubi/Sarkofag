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
        public AddStudent()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\dane.txt";
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
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }
    }
}
