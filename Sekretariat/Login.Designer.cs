namespace Sekretariat
{
    partial class Login
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

        private void InitializeComponent()
        {
            this.CaptchaCheck = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.CaptchaBox = new System.Windows.Forms.PictureBox();
            this.RandomCaptcha = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaCheck
            // 
            this.CaptchaCheck.Location = new System.Drawing.Point(317, 265);
            this.CaptchaCheck.Name = "CaptchaCheck";
            this.CaptchaCheck.Size = new System.Drawing.Size(285, 23);
            this.CaptchaCheck.TabIndex = 19;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(317, 112);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(285, 23);
            this.PasswordInput.TabIndex = 18;
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(317, 72);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(285, 23);
            this.UserInput.TabIndex = 17;
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignIn.Location = new System.Drawing.Point(493, 356);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(109, 29);
            this.SignIn.TabIndex = 16;
            this.SignIn.Text = "Zaloguj";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // CaptchaBox
            // 
            this.CaptchaBox.BackgroundImage = global::Sekretariat.Properties.Resources._1;
            this.CaptchaBox.Location = new System.Drawing.Point(174, 265);
            this.CaptchaBox.Name = "CaptchaBox";
            this.CaptchaBox.Size = new System.Drawing.Size(120, 31);
            this.CaptchaBox.TabIndex = 15;
            this.CaptchaBox.TabStop = false;
            // 
            // RandomCaptcha
            // 
            this.RandomCaptcha.AutoSize = true;
            this.RandomCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.RandomCaptcha.Location = new System.Drawing.Point(317, 300);
            this.RandomCaptcha.Name = "RandomCaptcha";
            this.RandomCaptcha.Size = new System.Drawing.Size(62, 15);
            this.RandomCaptcha.TabIndex = 14;
            this.RandomCaptcha.Text = "losuj nowy";
            this.RandomCaptcha.Click += new System.EventHandler(this.RandomCaptcha_Click);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(248, 226);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(354, 15);
            this.InstructionLabel.TabIndex = 13;
            this.InstructionLabel.Text = "Wpisz znaki, ktore widzisz na ponizszym obrazku, aby kontynowac";
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerificationLabel.Location = new System.Drawing.Point(192, 193);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(102, 21);
            this.VerificationLabel.TabIndex = 12;
            this.VerificationLabel.Text = "Weryfikacja";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(241, 110);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 21);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Haslo";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(193, 70);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(101, 21);
            this.UserLabel.TabIndex = 10;
            this.UserLabel.Text = "Uzytkownik";
            // 
            // Login
            // 
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
            this.Name = "Login";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox CaptchaCheck;
        private TextBox PasswordInput;
        private TextBox UserInput;
        private Button SignIn;
        private PictureBox CaptchaBox;
        private Label RandomCaptcha;
        private Label InstructionLabel;
        private Label VerificationLabel;
        private Label PasswordLabel;
        private Label UserLabel;
    }
}
