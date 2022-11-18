using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            if (firstNameInput.Text != "" || lastNameInput.Text != "" || classInput.Text != "")
            {
                using(var connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\student.mdf;Integrated Security=True"))
                using(var cmd = new SqlDataAdapter())
                using(var insertCommand = new SqlCommand("INSERT INTO [students](first_name, last_name, class) VALUES(@name, @lname, @class)"))
                {
                    insertCommand.Connection = connection1;
                    cmd.InsertCommand = insertCommand;
                    cmd.InsertCommand.Parameters.AddWithValue("@name", firstNameInput.Text);
                    cmd.InsertCommand.Parameters.AddWithValue("@lname", lastNameInput.Text);
                    cmd.InsertCommand.Parameters.AddWithValue("@class", classInput.Text);
                    connection1.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }

                firstNameInput.Clear();
                lastNameInput.Clear();
                classInput.Clear();
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
           
        }


    }
}
