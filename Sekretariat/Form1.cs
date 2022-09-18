using System.Drawing.Printing;
using System.Reflection;

namespace Sekretariat
{
    public partial class Secretariat : Form
    {
        public Secretariat()
        {
            InitializeComponent();
        }

        public void RandomImage()
        {
            var random = new Random();
            int r = random.Next(1, 7);

            switch (r)
            {
                case 1:
                    CaptchaBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    CaptchaBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    CaptchaBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    CaptchaBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    CaptchaBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    CaptchaBox.Image = Properties.Resources._6;
                    break;
                case 7:
                    CaptchaBox.Image = Properties.Resources._7;
                    break;
            }
        }

        private void RandomCaptcha_Click(object sender, EventArgs e)
        {
            RandomImage();
        }

        public string GetCurrentCaptcha()
        {
            string captcha = "";

            return captcha;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string log = "admin";
            string pwd = "Qwerty1@34";
            string cap = GetCurrentCaptcha();

            bool login = (log == UserInput.Text && pwd == PasswordInput.Text);
            bool matchCap = (cap == CaptchaCheck.Text);



        }
    }
}