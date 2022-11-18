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
            this.CriteriaLabel = new System.Windows.Forms.Label();
            this.startsWith = new System.Windows.Forms.ComboBox();
            this.studentName = new System.Windows.Forms.ComboBox();
            this.search_button = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.RichTextBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.AddStudentTab = new System.Windows.Forms.TabPage();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.classLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
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
            this.SearchStudentTab.Controls.Add(this.search_button);
            this.SearchStudentTab.Controls.Add(this.searchData);
            this.SearchStudentTab.Controls.Add(this.searchInput);
            this.SearchStudentTab.Location = new System.Drawing.Point(4, 24);
            this.SearchStudentTab.Name = "SearchStudentTab";
            this.SearchStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchStudentTab.Size = new System.Drawing.Size(789, 416);
            this.SearchStudentTab.TabIndex = 0;
            this.SearchStudentTab.Text = "Wyszukaj ucznia/uczniów";
            this.SearchStudentTab.UseVisualStyleBackColor = true;
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
            this.startsWith.Items.AddRange(new object[] {
            "równe",
            "zawiera",
            "rozpoczyna się od"});
            this.startsWith.Location = new System.Drawing.Point(314, 58);
            this.startsWith.Name = "startsWith";
            this.startsWith.Size = new System.Drawing.Size(153, 23);
            this.startsWith.TabIndex = 10;
            // 
            // studentName
            // 
            this.studentName.FormattingEnabled = true;
            this.studentName.Items.AddRange(new object[] {
            "Nazwisko",
            "Imię",
            "Klasa"});
            this.studentName.Location = new System.Drawing.Point(83, 58);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(153, 23);
            this.studentName.TabIndex = 9;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(553, 101);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(151, 23);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Szukaj";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchData
            // 
            this.searchData.Location = new System.Drawing.Point(6, 142);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(777, 261);
            this.searchData.TabIndex = 7;
            this.searchData.Text = "";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(551, 58);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(153, 23);
            this.searchInput.TabIndex = 6;
            // 
            // AddStudentTab
            // 
            this.AddStudentTab.Controls.Add(this.addStudentButton);
            this.AddStudentTab.Controls.Add(this.classLabel);
            this.AddStudentTab.Controls.Add(this.lastNameLabel);
            this.AddStudentTab.Controls.Add(this.nameLabel);
            this.AddStudentTab.Controls.Add(this.classInput);
            this.AddStudentTab.Controls.Add(this.lastNameInput);
            this.AddStudentTab.Controls.Add(this.firstNameInput);
            this.AddStudentTab.Location = new System.Drawing.Point(4, 24);
            this.AddStudentTab.Name = "AddStudentTab";
            this.AddStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudentTab.Size = new System.Drawing.Size(789, 416);
            this.AddStudentTab.TabIndex = 1;
            this.AddStudentTab.Text = "Dodaj ucznia";
            this.AddStudentTab.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(453, 255);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 6;
            this.addStudentButton.Text = "Dodaj";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classLabel.Location = new System.Drawing.Point(194, 197);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(57, 25);
            this.classLabel.TabIndex = 5;
            this.classLabel.Text = "Klasa";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(194, 153);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(93, 25);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Nazwisko";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(194, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Imię";
            // 
            // classInput
            // 
            this.classInput.Location = new System.Drawing.Point(321, 200);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(207, 23);
            this.classInput.TabIndex = 2;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(321, 156);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(207, 23);
            this.lastNameInput.TabIndex = 1;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(321, 112);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(207, 23);
            this.firstNameInput.TabIndex = 0;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
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
        private Button search_button;
        private RichTextBox searchData;
        private TextBox searchInput;
        private Label classLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private TextBox classInput;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private Button addStudentButton;
    }
}
