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
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.RandomCaptcha = new System.Windows.Forms.Label();
            this.CaptchaBox = new System.Windows.Forms.PictureBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.CaptchaCheck = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(191, 62);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(101, 21);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Uzytkownik";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(239, 102);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 21);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Haslo";
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerificationLabel.Location = new System.Drawing.Point(190, 185);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(102, 21);
            this.VerificationLabel.TabIndex = 2;
            this.VerificationLabel.Text = "Weryfikacja";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(246, 218);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(354, 15);
            this.InstructionLabel.TabIndex = 3;
            this.InstructionLabel.Text = "Wpisz znaki, ktore widzisz na ponizszym obrazku, aby kontynowac";
            // 
            // RandomCaptcha
            // 
            this.RandomCaptcha.AutoSize = true;
            this.RandomCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.RandomCaptcha.Location = new System.Drawing.Point(315, 292);
            this.RandomCaptcha.Name = "RandomCaptcha";
            this.RandomCaptcha.Size = new System.Drawing.Size(62, 15);
            this.RandomCaptcha.TabIndex = 4;
            this.RandomCaptcha.Text = "losuj nowy";
            this.RandomCaptcha.Click += new System.EventHandler(this.RandomCaptcha_Click);
            // 
            // CaptchaBox
            // 
            this.CaptchaBox.BackgroundImage = global::Sekretariat.Properties.Resources._1;
            this.CaptchaBox.Location = new System.Drawing.Point(172, 257);
            this.CaptchaBox.Name = "CaptchaBox";
            this.CaptchaBox.Size = new System.Drawing.Size(120, 31);
            this.CaptchaBox.TabIndex = 5;
            this.CaptchaBox.TabStop = false;
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignIn.Location = new System.Drawing.Point(491, 348);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(109, 29);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Zaloguj";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(315, 64);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(285, 23);
            this.UserInput.TabIndex = 7;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(315, 104);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(285, 23);
            this.PasswordInput.TabIndex = 8;
            // 
            // CaptchaCheck
            // 
            this.CaptchaCheck.Location = new System.Drawing.Point(315, 257);
            this.CaptchaCheck.Name = "CaptchaCheck";
            this.CaptchaCheck.Size = new System.Drawing.Size(285, 23);
            this.CaptchaCheck.TabIndex = 9;
            // 
            // Secretariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaptchaCheck);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.CaptchaBox);
            this.Controls.Add(this.RandomCaptcha);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Secretariat";
            this.Text = "Sekretariat";
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserLabel;
        private Label PasswordLabel;
        private Label VerificationLabel;
        private Label InstructionLabel;
        private Label RandomCaptcha;
        private PictureBox CaptchaBox;
        private Button SignIn;
        private TextBox UserInput;
        private TextBox PasswordInput;
        private TextBox CaptchaCheck;
    }
}