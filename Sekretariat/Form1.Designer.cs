namespace Sekretariat
{
    partial class Secretariat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secretariat));
            this.AddStudent = new Sekretariat.AddStudent();
            this.loginAdmin = new Sekretariat.Login();
            this.SearchStudent = new Sekretariat.SearchStudent();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddStudent.Location = new System.Drawing.Point(0, -2);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(800, 450);
            this.AddStudent.TabIndex = 10;
            // 
            // loginAdmin
            // 
            this.loginAdmin.Location = new System.Drawing.Point(0, -2);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(800, 450);
            this.loginAdmin.TabIndex = 11;
            // 
            // SearchStudent
            // 
            this.SearchStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchStudent.Location = new System.Drawing.Point(0, -2);
            this.SearchStudent.Name = "SearchStudent";
            this.SearchStudent.Size = new System.Drawing.Size(800, 450);
            this.SearchStudent.TabIndex = 12;
            // 
            // Secretariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchStudent);
            this.Controls.Add(this.loginAdmin);
            this.Controls.Add(this.AddStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Secretariat";
            this.Text = "Sekretariat";
            this.ResumeLayout(false);
        }

        #endregion
        private AddStudent AddStudent;
        private Login loginAdmin;
        private SearchStudent SearchStudent;
    }
}