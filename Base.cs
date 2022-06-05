using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace LABORATOR6___EmguCV
{
    public partial class Base : BusinessLogic
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private Image<Bgr, byte> MyImage()
        {
            var myImage = new Image<Bgr, byte>(OpenFile.FileName);
            pictureBox1.Image = myImage.ToBitmap();
            return myImage;
        }

        private void UploadImage(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();
        }

        private void ConvertToGrayScale(Image<Bgr, byte> myImage, out Image<Gray, byte> grayImage)
        {
            grayImage = myImage.Convert<Gray, byte>();
            pictureBox2.Image = grayImage.ToBitmap();
            grayImage[0, 0] = new Gray(200);
        }

        private void ShowImageHistogram(object sender, EventArgs e)
        {
            var v = new HistogramViewer();
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();

            v.HistogramCtrl.GenerateHistograms(myImage, 255);
            v.Show();
        }

        private Image<Bgr, byte> ChangeBrightnessAndContrast(Image<Bgr, byte> myImage)
        {
            var alpha = float.Parse(textBox1.Text);
            var beta = int.Parse(textBox2.Text);
            var result = myImage.Mul(alpha) + beta;
            return result;
        }

        private void GammaCorrect(Image<Bgr, byte> myImage)
        {
            var coefficient = float.Parse(gammaCoefficient.Text);
            myImage._GammaCorrect(coefficient);
        }

        private void ImageResize(Image<Bgr, byte> myImage)
        {
            var resizeCoefficientValue = float.Parse(resizeCoefficient.Text);
            myImage.Resize(resizeCoefficientValue, Inter.Cubic);
        }

        private Image<Bgr, byte> MouseUpFromImage()
        {
            var img = new Bitmap(pictureBox7.Image).ToImage<Bgr, byte>();
            img.ROI = Rect;
            var imgROI = img.Copy();
            return imgROI;
        }

        private Image<Bgr, byte> ImageRotate(Image<Bgr, byte> myImage)
        {
            var angleToRotate = float.Parse(angle.Text);
            var image = myImage.Rotate(angleToRotate, new Bgr(Color.Gray), true);
            return image;
        }

        private void ConvertToGrayScale(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();

            ConvertToGrayScale(myImage, out var grayImage);
        }

        private void ChangeBrightnessAndContrast(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();

            var result = ChangeBrightnessAndContrast(myImage);
            pictureBox2.Image = result.ToBitmap();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void GamaCorrect(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();

            GammaCorrect(myImage);
            pictureBox4.Image = myImage.ToBitmap();
        }

        private void ImageResize(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();

            ImageResize(myImage);
            pictureBox5.Image = myImage.ToBitmap();
        }

        private void ImageRotate(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox1.Image = myImage.ToBitmap();

            var image = ImageRotate(myImage);
            pictureBox6.Image = image.ToBitmap();
        }

        private void MouseUpFromImage(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            if (pictureBox7.Image == null || Rect == Rectangle.Empty) return;

            var imgROI = MouseUpFromImage();

            pictureBox8.Image = imgROI.ToBitmap();
        }

        private void MouseMoveThroughImage(object sender, MouseEventArgs e)
        {
            if (pictureBox7.Image == null) return;
            MouseMoveThroughImage(e);
        }

        private void ExtractRegionOfInterest(object sender, EventArgs e)
        {
            if (GetFile()) return;
            var myImage = MyImage();
            pictureBox7.Image = myImage.ToBitmap();
        }

        private async void Blending(object sender, EventArgs e)
        {
            var fileNames = Directory.GetFiles(@"C:\Users\radvo\OneDrive\Imagini\Capturi de ecran", "*.png");
            var listImages = fileNames.Select(file => new Image<Bgr, byte>(file)).ToList();

            for (var i = 0; i < listImages.Count - 2; i++)
            for (var alpha = 0.0; alpha <= 1.0; alpha += 0.01)
            {
                pictureBox9.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).AsBitmap();
                await Task.Delay(5);
            }
        }
    }
}