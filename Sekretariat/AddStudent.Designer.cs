namespace Sekretariat
{
    partial class AddStudent
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentTab = new System.Windows.Forms.TabControl();
            this.SearchStudentTab = new System.Windows.Forms.TabPage();
            this.AddStudentTab = new System.Windows.Forms.TabPage();
            this.CriteriaLabel = new System.Windows.Forms.Label();
            this.startsWith = new System.Windows.Forms.ComboBox();
            this.studentName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentTab.SuspendLayout();
            this.SearchStudentTab.SuspendLayout();
            this.AddStudentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentTab
            // 
            this.StudentTab.Controls.Add(this.SearchStudentTab);
            this.StudentTab.Controls.Add(this.AddStudentTab);
            this.StudentTab.Location = new System.Drawing.Point(3, 3);
            this.StudentTab.Name = "StudentTab";
            this.StudentTab.SelectedIndex = 0;
            this.StudentTab.Size = new System.Drawing.Size(797, 444);
            this.StudentTab.TabIndex = 0;
            // 
            // SearchStudentTab
            // 
            this.SearchStudentTab.Controls.Add(this.CriteriaLabel);
            this.SearchStudentTab.Controls.Add(this.startsWith);
            this.SearchStudentTab.Controls.Add(this.studentName);
            this.SearchStudentTab.Controls.Add(this.button1);
            this.SearchStudentTab.Controls.Add(this.richTextBox1);
            this.SearchStudentTab.Controls.Add(this.textBox1);
            this.SearchStudentTab.Location = new System.Drawing.Point(4, 24);
            this.SearchStudentTab.Name = "SearchStudentTab";
            this.SearchStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchStudentTab.Size = new System.Drawing.Size(789, 416);
            this.SearchStudentTab.TabIndex = 0;
            this.SearchStudentTab.Text = "Wyszukaj ucznia/uczniów";
            this.SearchStudentTab.UseVisualStyleBackColor = true;
            // 
            // AddStudentTab
            // 
            this.AddStudentTab.Controls.Add(this.label3);
            this.AddStudentTab.Controls.Add(this.label2);
            this.AddStudentTab.Controls.Add(this.label1);
            this.AddStudentTab.Controls.Add(this.textBox4);
            this.AddStudentTab.Controls.Add(this.textBox3);
            this.AddStudentTab.Controls.Add(this.textBox2);
            this.AddStudentTab.Location = new System.Drawing.Point(4, 24);
            this.AddStudentTab.Name = "AddStudentTab";
            this.AddStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudentTab.Size = new System.Drawing.Size(789, 416);
            this.AddStudentTab.TabIndex = 1;
            this.AddStudentTab.Text = "Dodaj ucznia";
            this.AddStudentTab.UseVisualStyleBackColor = true;
            // 
            // CriteriaLabel
            // 
            this.CriteriaLabel.AutoSize = true;
            this.CriteriaLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CriteriaLabel.Location = new System.Drawing.Point(83, 13);
            this.CriteriaLabel.Name = "CriteriaLabel";
            this.CriteriaLabel.Size = new System.Drawing.Size(274, 25);
            this.CriteriaLabel.TabIndex = 11;
            this.CriteriaLabel.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // startsWith
            // 
            this.startsWith.FormattingEnabled = true;
            this.startsWith.Location = new System.Drawing.Point(314, 58);
            this.startsWith.Name = "startsWith";
            this.startsWith.Size = new System.Drawing.Size(153, 23);
            this.startsWith.TabIndex = 10;
            // 
            // studentName
            // 
            this.studentName.FormattingEnabled = true;
            this.studentName.Items.AddRange(new object[] {
            "Imię",
            "Nazwisko"});
            this.studentName.Location = new System.Drawing.Point(83, 58);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(153, 23);
            this.studentName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(777, 261);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 23);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(286, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 23);
            this.textBox4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.StudentTab);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(800, 450);
            this.StudentTab.ResumeLayout(false);
            this.SearchStudentTab.ResumeLayout(false);
            this.SearchStudentTab.PerformLayout();
            this.AddStudentTab.ResumeLayout(false);
            this.AddStudentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl StudentTab;
        private TabPage SearchStudentTab;
        private TabPage AddStudentTab;
        private Label CriteriaLabel;
        private ComboBox startsWith;
        private ComboBox studentName;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
