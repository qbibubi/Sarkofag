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
            var line = classInput.Text + " " + firstNameInput.Text + " " + lastNameInput.Text;
            File.AppendAllText(@"C:\File\file.txt", line + Environment.NewLine);
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }
    }
}
