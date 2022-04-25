using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using LABORATOR6___EmguCV;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void videoForm_Click(object sender, EventArgs e)
        {
            Form2 video = new Form2();
            video.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private async void blend_Click(object sender, EventArgs e)
        {
            string[] fileNames = Directory.GetFiles(@"C:\Users\radvo\OneDrive\Imagini\Capturi de ecran", "*.png");
            List<Image<Bgr, byte>> listImages = new List<Image<Bgr, byte>>();
            foreach (var file in fileNames)
            {
                listImages.Add(new Image<Bgr, byte>(file));
            }

            for (int i = 0; i < listImages.Count-2; i++)
            {
                for (double alpha = 0.0; alpha <=1.0; alpha+=0.01)
                {
                    pictureBox9.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).AsBitmap();
                    await Task.Delay(5);
                }
            }
        }

        private void watermark_Click(object sender, EventArgs e)
        {
            VideoCapture capture = new VideoCapture(@"C:\Users\radvo\Pictures\Star Wars Reflections 4K Unreal Engine Real-Time Ray Tracing Demonstration (360).mp4");

            int Fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            var Fps = capture.Get(CapProp.Fps);
            var TotalFrame = capture.Get(CapProp.FrameCount);


            string destionpath = @"C:\Users\radvo\Pictures\watermark1.mp4";
            using (VideoWriter writer = new VideoWriter(destionpath, Fourcc, Fps, new Size(Width, Height), true))
            {
                Image<Bgr, byte> logo = new Image<Bgr, byte>(@"C:\Users\radvo\Downloads\253497242_1440234176370432_1779573431902212064_n_10x10.jpg");
                Mat m = new Mat();

                var FrameNo = 1;
                while (FrameNo < TotalFrame)
                {
                    capture.Read(m);
                    Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                    img.ROI = new Rectangle(Width - logo.Width - 30, 10, logo.Width, logo.Height);
                    if (logo != null) logo.CopyTo(img);

                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    FrameNo++;
                }
            }

        }
    }
}
