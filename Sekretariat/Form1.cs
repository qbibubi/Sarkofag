using System.Drawing.Printing;

namespace Sekretariat
{
    public partial class Secretariat : Form
    {
        private ImageList imgList;

        public Secretariat()
        {
            InitializeComponent();
            imgList = new ImageList();
        }
        public void RandomImage()
        {
            var random = new Random();
            int r = random.Next(1, 7);

            CaptchaBox.Image = imgList.Images[r];
        }

        private void Secretariat_Load(object sender, EventArgs e)
        {
            Image img;
            for (int i = 1; i <= 7; i++)
            {
                string path = "C:/Users/jakub/source/repos/Sekretariat/Sekretariat/res/" + i.ToString() + ".png";
                img = new Bitmap(path);

                imgList.Images.Add(img);
            }

            RandomImage();
        }

        private void RandomCaptcha_Click(object sender, EventArgs e)
        {
            RandomImage();
        }
    }
}