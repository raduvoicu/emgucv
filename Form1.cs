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
                pictureBox5.Image= myImage.ToBitmap();

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
                myImage.Rotate(angleToRotate,new Bgr(Color.Gray),true);
                pictureBox6.Image = myImage.ToBitmap();

            }
        }
    }
}
