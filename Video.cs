using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace LABORATOR6___EmguCV
{
    public partial class Video : BusinessLogic
    {
        public Video()
        {
            InitializeComponent();
        }

        

        private void VideoLoad(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (LoadVideo(ofd)) return;
        }

        private bool LoadVideo(FileDialog ofd)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return false;
            _capture = new VideoCapture(ofd.FileName);
            var m = new Mat();
            _capture.Read(m);
            pictureBox1.Image = m.ToBitmap();

            TotalFrame = (int) _capture.Get(CapProp.FrameCount);
            Fps = _capture.Get(CapProp.Fps);
            FrameNo = 1;

            var numericUpDown1 = new NumericUpDown();
            numericUpDown1.Value = FrameNo;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = TotalFrame;

            if (_capture == null) return true;

            IsReadingFrame = true;
            ReadAllFrames();

            return false;
        }

        private void autoVideoLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            AutoVideoLoad(ofd);
        }

        private void AutoVideoLoad(OpenFileDialog ofd)
        {
            try
            {
                CameraCapture = new VideoCapture(ofd.FileName);
                NewBackgroundImage = new Image<Bgr, byte>(@"C:\Users\radvo\Pictures\4256.jpeg");
                FgDetector = new BackgroundSubtractorMOG2();
                Application.Idle += ProcessFrames;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProcessFrames(object sender, EventArgs e)
        {
            var frame = CameraCapture.QueryFrame();
            var frameImage = frame.ToImage<Bgr, byte>();

            var foregroundMask = new Mat();
            FgDetector.Apply(frame, foregroundMask);
            var foregroundMaskImage = foregroundMask.ToImage<Gray, byte>();
            foregroundMaskImage = foregroundMaskImage.Not();

            var copyOfNewBackgroundImage =
                NewBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
            copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

            foregroundMaskImage = foregroundMaskImage.Not();
            frameImage = frameImage.Copy(foregroundMaskImage);
            frameImage = frameImage.Or(copyOfNewBackgroundImage);
            pictureBox1.Image = frameImage.ToBitmap();
        }

        private void AbruptMerge(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (LoadVideo(ofd)) return;
            Console.WriteLine($@"Delay starting at {DateTime.Now}");
            Console.WriteLine($@"Finished delay at {DateTime.Now}");
            var ofd2 = new OpenFileDialog();
            if (LoadVideo(ofd2)) return;
        }

        private async void ReadAllFrames()
        {
            while (IsReadingFrame && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = _capture.QueryFrame();
                pictureBox1.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = FrameNo + @"/" + TotalFrame;
            }
        }
    }
}