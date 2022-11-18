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
using static System.Net.Mime.MediaTypeNames;

namespace Sekretariat
{
    public partial class AddStudent : UserControl
    {
        public string path = @"C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\dane.txt";
        public string text = "";
        public int last = 0;

        public AddStudent()
        {
            InitializeComponent();
            text = System.IO.File.ReadAllText(path);
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            text = System.IO.File.ReadAllText(path);
            TextWriter txt = new StreamWriter(path);
            last++;

            string data = text + System.Environment.NewLine
                          + last.ToString() + " " 
                          + firstNameInput.Text + " " 
                          + lastNameInput.Text + " " 
                          + classInput.Text + " ";

            txt.Write(data);
            txt.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            searchData.Clear();
            string text = File.ReadAllText(path);
            string[] lines = text.Split(Environment.NewLine);

            object obiekt = studentName.SelectedItem;
            string kategoria = Convert.ToString(obiekt);

            object obiekt2 = startsWith.SelectedItem;
            string kategoria2 = Convert.ToString(obiekt2);

            foreach (string line in lines)
            {
                
                if (kategoria == "Imię")
                {
                    
                    if (kategoria2 == "rozpoczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1].Substring(0, 1) == searchInput.Text.Substring(0, 1))
                        {
                            searchData.Text += System.Environment.NewLine+ line;
                        }

                    }
                    else if(kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1].Contains(searchInput.Text))
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1] == searchInput.Text)
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                }else if (kategoria == "Nazwisko")
                {

                    if (kategoria2 == "rozpoczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2].Substring(0, 1) == searchInput.Text.Substring(0, 1))
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }

                    }
                    else if (kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2].Contains(searchInput.Text))
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2] == searchInput.Text)
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                }
                else if (kategoria == "Klasa")
                {

                    if (kategoria2 == "rozpoczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3].Substring(0, 1) == searchInput.Text.Substring(0, 1))
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }

                    }
                    else if (kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3].Contains(searchInput.Text))
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3] == searchInput.Text)
                        {
                            searchData.Text += System.Environment.NewLine + line;
                        }
                    }
                }
            }
        }
    }
}
