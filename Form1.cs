using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace EmguCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox2.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            HistogramViewer v = new HistogramViewer();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox2.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);

                v.HistogramCtrl.GenerateHistograms(myImage, 255);
                v.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            HistogramViewer v = new HistogramViewer();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Image<Gray, byte> myImage = new Image<Gray, byte>(openFile.FileName);
                //pictureBox1.Image = myImage.ToBitmap();
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox3.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);

                v.HistogramCtrl.GenerateHistograms(myImage, 255);
                v.Show();
                var alfa = float.Parse(textBox1.Text);
                var beta = int.Parse(textBox2.Text);
                var result = myImage.Mul(alfa) + beta;
                pictureBox2.Image = result.ToBitmap();
                //for (int i = 0; i < myImage.Width / 2; i++) //change selected area pixels to white
                //{
                //    for (int j = 0; j < myImage.Height / 2; j++)
                //    {
                //        var x = myImage[i, j];
                //        grayImage[i, j].Intensity * alfa + beta;
                //        //myImage[i, j] = grayImage[i,j] + alfa + beta;
                //    }
                //}


            }
        }

        private void exitBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gamaCorrect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            HistogramViewer v = new HistogramViewer();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox3.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);

                v.HistogramCtrl.GenerateHistograms(myImage, 255);
                v.Show();
                var alfa = float.Parse(textBox1.Text);
                var beta = int.Parse(textBox2.Text);
                var result = myImage.Mul(alfa) + beta;
                pictureBox2.Image = result.ToBitmap();
                var coeff = float.Parse(gammaCoefficient.Text);
                myImage._GammaCorrect(coeff);
                pictureBox4.Image = myImage.ToBitmap();
            }

        }

        private void imageResize_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            HistogramViewer v = new HistogramViewer();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox3.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);

                v.HistogramCtrl.GenerateHistograms(myImage, 255);
                v.Show();

                var alfa = float.Parse(textBox1.Text);
                var beta = int.Parse(textBox2.Text);
                var result = myImage.Mul(alfa) + beta;
                pictureBox2.Image = result.ToBitmap();

                var coeff = float.Parse(gammaCoefficient.Text);
                myImage._GammaCorrect(coeff);
                pictureBox4.Image = myImage.ToBitmap();

                var resizeCoefficientValue = float.Parse(resizeCoefficient.Text);
                myImage.Resize(resizeCoefficientValue, Emgu.CV.CvEnum.Inter.Cubic);
                pictureBox5.Image = myImage.ToBitmap();

            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            HistogramViewer v = new HistogramViewer();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();

                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox3.Image = grayImage.ToBitmap();
                grayImage[0, 0] = new Gray(200);

                v.HistogramCtrl.GenerateHistograms(myImage, 255);
                v.Show();

                var alfa = float.Parse(textBox1.Text);
                var beta = int.Parse(textBox2.Text);
                var result = myImage.Mul(alfa) + beta;
                pictureBox2.Image = result.ToBitmap();

                var coeff = float.Parse(gammaCoefficient.Text);
                myImage._GammaCorrect(coeff);
                pictureBox4.Image = myImage.ToBitmap();

                var resizeCoefficientValue = float.Parse(resizeCoefficient.Text);
                myImage.Resize(resizeCoefficientValue, Emgu.CV.CvEnum.Inter.Cubic);
                pictureBox5.Image = myImage.ToBitmap();

                var angleToRotate = float.Parse(angle.Text);
                var image = myImage.Rotate(angleToRotate, new Bgr(Color.Gray), true);
                pictureBox6.Image = image.ToBitmap();

            }
        }

        private Rectangle rect; Point StartROI;
        private bool MouseDown;

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.FromArgb(53, 104, 131), 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }

        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBox7.Image == null || rect == Rectangle.Empty)
            { return; }

            var img = new Bitmap(pictureBox7.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();

            pictureBox8.Image = imgROI.ToBitmap();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox7.Image == null)
            {
                return;
            }

            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
                Math.Min(StartROI.Y, e.Y),
                width,
                height);
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox7.Image = myImage.ToBitmap();

            }
        }
    }
}
