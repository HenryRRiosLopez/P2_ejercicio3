using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        int cmR, cmG, cmB;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes PNG|*.png";
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                            bmp2.SetPixel(x, y, Color.FromArgb(c.R, c.G, c.B));


                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;

                    if (((60 <= ciR) && (ciR < 205)) && ((63 < ciG) && (ciG < 185)) && ((56 < ciB) && (ciB < 180)))
                    {

                        for (int x = i; x < i + 5; x++)
                        {
                            for (int y = j; y < j + 5; y++)
                            {
                                bmp2.SetPixel(x, y, Color.Green);
                            }
                        }
                    }

                }
            pictureBox2.Image = bmp2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                            bmp2.SetPixel(x, y, Color.FromArgb(c.R, c.G, c.B));

                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;

                    if (((0 <= ciR) && (ciR < 30)) && ((0 < ciG) && (ciG < 60)) && ((10 < ciB) && (ciB < 160)))
                    {

                        for (int x = i; x < i + 5; x++)
                        {
                            for (int y = j; y < j + 5; y++)
                            {
                                bmp2.SetPixel(x, y, Color.Red);
                            }
                        }
                    }
                }
            pictureBox2.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                            bmp2.SetPixel(x, y, Color.FromArgb(c.R, c.G, c.B));

                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;

                    if (((20 <= ciR) && (ciR < 60)) && ((40 < ciG) && (ciG < 90)) && ((39 < ciB) && (ciB < 70)))
                    {

                        for (int x = i; x < i + 5; x++)
                        {
                            for (int y = j; y < j + 5; y++)
                            {
                                bmp2.SetPixel(x, y, Color.Blue);
                            }
                        }
                    }

                }
            pictureBox2.Image = bmp2;
        }

 

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
            cmR = 0;
            cmG = 0;
            cmB = 0;
            for (int i = e.X; i < e.X + 5; i++)
                for (int j = e.Y; j < e.Y + 5; j++)
                {
                    c = bmp.GetPixel(i, j);
                    cmR = cmR + c.R;
                    cmG = cmG + c.G;
                    cmB = cmB + c.B;
                }
            cmR = cmR / 25;
            cmG = cmG / 25;
            cmB = cmB / 25;
            textBox1.Text = cmR.ToString();
            textBox2.Text = cmG.ToString();
            textBox3.Text = cmB.ToString();
        }
    }
}
