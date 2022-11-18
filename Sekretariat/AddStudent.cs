using Google.Protobuf.WellKnownTypes;
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
            if (firstNameInput.Text != "" 
                || lastNameInput.Text != "" 
                || classInput.Text != "")
            {
                using(var connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                using(var cmd = new SqlDataAdapter())
                using(var insertCommand = new SqlCommand("INSERT INTO [students](first_name, last_name, class) VALUES(@name, @lname, @class)"))
                {
                    insertCommand.Connection = connection1;
                    cmd.InsertCommand = insertCommand;
                    cmd.InsertCommand.Parameters.AddWithValue("@name", firstNameInput.Text);
                    cmd.InsertCommand.Parameters.AddWithValue("@lname", lastNameInput.Text);
                    cmd.InsertCommand.Parameters.AddWithValue("@class", classInput.Text);
                    
                    // Open connection and execute query
                    connection1.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }

                // Clear inputs
                firstNameInput.Clear();
                lastNameInput.Clear();
                classInput.Clear();
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (studentName.SelectedItem.ToString() != "" 
                || startsWith.SelectedItem.ToString() != "" 
                || searchInput.Text != "")
            {
                switch(startsWith.SelectedItem.ToString())
                {
                    case "Imię":
                        if (startsWith.SelectedItem.ToString() == "zawiera")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE first_name LIKE '%" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        } else if (startsWith.SelectedItem.ToString() == "rozpoczyna się od")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE first_name LIKE '" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        } else
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE first_name='" + searchInput.Text + "'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "Naziwsko":
                        if (startsWith.SelectedItem.ToString() == "zawiera")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE last_name LIKE '%" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        else if (startsWith.SelectedItem.ToString() == "rozpoczyna się od")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE last_name LIKE '" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE last_name='" + firstNameInput.Text + "'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "Klasa":
                        if (startsWith.SelectedItem.ToString() == "zawiera")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE class LIKE '%" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        else if (startsWith.SelectedItem.ToString() == "rozpoczyna się od")
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE class LIKE '" + searchInput.Text + "%'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Source\Repos\qbibubi\Sarkofag\Sekretariat\students.mdf;Integrated Security=True"))
                            using (var cmd = new SqlDataAdapter())
                            using (var query = new SqlCommand("SELECT * FROM [students] WHERE class='" + searchInput.Text + "'"))
                            {
                                query.Connection = conn;
                                cmd.SelectCommand = query;

                                // Open connection and execute query
                                conn.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        break;
                }
            }
        }
    }
}
