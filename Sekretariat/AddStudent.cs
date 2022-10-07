﻿using System;
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

        public string path = @"C:\Users\student\source\repos\qbibubi\Sarkofag\Sekretariat\dane.txt";

        private void addStudentButton_Click(object sender, EventArgs e)
        {
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
            var choice = startsWith.Text;
            var search = searchInput.Text;
            var output = "";

            switch (choice)
            {
                case "równe":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if (line.Equals(search))
                        {
                            output = line + System.Environment.NewLine;
                        }
                    }
                    break;
                case "rozpoczyna się od":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if (line.StartsWith(search))
                        {
                            output = line + System.Environment.NewLine;
                        }
                    }
                    break;
                case "zawiera":
                    foreach (var line in File.ReadAllLines(path))
                    {
                        if(line.Contains(search))
                        {
                            output = line + System.Environment.NewLine;
                        }
                    }
                    break;
            }
            searchData.Text += output;
        }
    }
}
