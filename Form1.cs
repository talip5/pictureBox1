using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"Images\a.bmp");

            pictureBox1.BackColor = Color.Orange;
            pictureBox1.SizeMode =PictureBoxSizeMode.StretchImage;
            //pictureBox1.Image = Image.FromFile("free.png");
            //pictureBox1.Image = Image.FromFile("picture\\free.png");
            //pictureBox1.Image = Image.FromFile(@"picture\free.png");

            //label2.Text = System.IO.Directory.GetCurrentDirectory();
            string resim = System.IO.Directory.GetCurrentDirectory();

            //Image image =Image.FromFile(@"Debug\free.png"); 
            //Path.GetFullPath(PicPath)
            //C:\Users\Furka\source\repos\Akaryakit_Otomasyonu\bin\Debug
            //label2.Text = System.IO.Path.GetFileName(resim);
            //label2.Text = System.IO.Path.GetFileName("C:\\Users\\Furka\\source\\repos\\Akaryakit_Otomasyonu\\bin\\Debug");
            label2.Text = System.IO.Path.GetFileName("C:\\Users\\Furka\\source\\repos\\Akaryakit_Otomasyonu\\bin");

            //pictureBox1.Image = Image.FromFile(@"C:\free.png");
            //pictureBox1.ImageLocation =@"C:\free.png";

        }
    }
}
