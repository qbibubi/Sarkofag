using System;
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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public string captcha = "mxyxw";
        public void RandomImage()
        {
            var random = new Random();
            int r = random.Next(1, 7);

            switch (r)
            {
                case 1:
                    CaptchaBox.Image = Properties.Resources._1;
                    captcha = "mxyxw";
                    break;
                case 2:
                    CaptchaBox.Image = Properties.Resources._2;
                    captcha = "b5nmm";
                    break;
                case 3:
                    CaptchaBox.Image = Properties.Resources._3;
                    captcha = "74853";
                    break;
                case 4:
                    CaptchaBox.Image = Properties.Resources._4;
                    captcha = "cg5dd";
                    break;
                case 5:
                    CaptchaBox.Image = Properties.Resources._5;
                    captcha = "x3deb";
                    break;
                case 6:
                    CaptchaBox.Image = Properties.Resources._6;
                    captcha = "befhd";
                    break;
                case 7:
                    CaptchaBox.Image = Properties.Resources._7;
                    captcha = "c7gd3";
                    break;
            }
        }

        private void RandomCaptcha_Click(object sender, EventArgs e)
        {
            RandomImage();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            var log = "admin";
            var pwd = "Qwerty1@34";
            bool login = (log == UserInput.Text && pwd == PasswordInput.Text);
            bool matchCap = (captcha == CaptchaCheck.Text);

            if (login && matchCap)
            {
                this.Hide();
            }
            else
            {
                UserInput.Clear();
                PasswordInput.Clear();
                CaptchaCheck.Clear();
                RandomImage();
            }
        }

    }
}
