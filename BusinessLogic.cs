using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace LABORATOR6___EmguCV
{
    public class BusinessLogic : Form
    {
        protected readonly OpenFileDialog OpenFile = new OpenFileDialog();
        protected Rectangle Rect;
        protected Point StartRoi;
        protected bool _mouseDown;
        protected int TotalFrame, FrameNo;
        protected double Fps;
        protected bool IsReadingFrame;
        protected VideoCapture _capture;
        protected static VideoCapture CameraCapture;
        protected Image<Bgr, byte> NewBackgroundImage;
        protected static IBackgroundSubtractor FgDetector;

        public bool GetFile()
        {
            return OpenFile.ShowDialog() != DialogResult.OK;
        }

        protected void LoadFormForAudio(object sender, EventArgs e)
        {
            var audio = new Audio();
            audio.Show();
        }

        protected void LoadFormForVideo(object sender, EventArgs e)
        {
            var video = new Video();
            video.Show();
        }

        protected void Watermark(object sender, EventArgs e)
        {
            var capture =
                new VideoCapture(
                    @"C:\Users\radvo\Pictures\Star Wars Reflections 4K Unreal Engine Real-Time Ray Tracing Demonstration (360).mp4");

            var fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            var width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            var height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            var fps = capture.Get(CapProp.Fps);
            var totalFrame = capture.Get(CapProp.FrameCount);


            const string destinationPath = @"C:\Users\radvo\Pictures\watermark1.mp4";
            using (var writer = new VideoWriter(destinationPath, fourcc, fps, new Size(width, height), true))
            {
                var logo = new Image<Bgr, byte>(@"C:\Users\radvo\Downloads\eu-.jpg");
                var m = new Mat();

                var frameNo = 1;
                var img = m.ToImage<Bgr, byte>();
                while (frameNo < totalFrame)
                {
                    capture.Read(m);
                    img.ROI = new Rectangle(width - logo.Width - 30, 10, logo.Width, logo.Height);
                    logo.CopyTo(img);

                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    frameNo++;
                }
            }
        }

        protected void MouseMoveThroughImage(MouseEventArgs e)
        {
            var width = Math.Max(StartRoi.X, e.X) - Math.Min(StartRoi.X, e.X);
            var height = Math.Max(StartRoi.Y, e.Y) - Math.Min(StartRoi.Y, e.Y);
            Rect = new Rectangle(Math.Min(StartRoi.X, e.X),
                Math.Min(StartRoi.Y, e.Y),
                width,
                height);
            Refresh();
        }

        protected void MouseDownOnImage(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            StartRoi = e.Location;
        }

        protected void DrawCroppedRegionOfInterest(object sender, PaintEventArgs e)
        {
            if (!_mouseDown) return;
            using (var pen = new Pen(Color.FromArgb(53, 104, 131), 1))
            {
                e.Graphics.DrawRectangle(pen, Rect);
            }
        }

        protected void ConcatenateThreeAudioFilesAsOne()
        {
            var first = new AudioFileReader(@"C:\Users\radvo\Music\Wav - Mp3\Stuff (mp3cut.net).mp3");
            var second = new AudioFileReader(@"C:\Users\radvo\Downloads\sample-9s.mp3");
            var third = new AudioFileReader(@"C:\Users\radvo\Downloads\file_example_MP3_700KB.mp3");

            var playlist = new ConcatenatingSampleProvider(new[] {first, second, third});
            WaveFileWriter.CreateWaveFile16(@"C:\Users\radvo\Downloads\somecombination.mp3", playlist);
        }

        protected void Pitch()
        {
            var inPath = @"C:\Users\radvo\Music\Wav - Mp3\Stuff (mp3cut.net).mp3";
            var semitone = Math.Pow(2, 1.0 / 12);
            var upOneTone = semitone * semitone;
            var downOneTone = 1.0 / upOneTone;
            using (var reader = new MediaFoundationReader(inPath))
            {
                var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                using (var device = new WaveOutEvent())
                {
                    pitch.PitchFactor = (float) upOneTone; // or downOneTone
                    // just playing the first 5 seconds of the file
                    device.Init(pitch.Take(TimeSpan.FromSeconds(5)));
                    device.Play();
                    while (device.PlaybackState == PlaybackState.Playing) Thread.Sleep(500);
                }
            }
        }

        protected void Resample()
        {
            var outRate = 16000;
            var inFile = @"C:\Users\radvo\Music\Wav - Mp3\Stuff (mp3cut.net).mp3";
            var outFile = @"C:\Users\radvo\Music\something.wav";
            using (var reader = new Mp3FileReader(inFile))
            {
                var outFormat = new WaveFormat(outRate, reader.WaveFormat.Channels);
                using (var resampler = new MediaFoundationResampler(reader, outFormat))
                {
                    resampler.ResamplerQuality = 60;
                    WaveFileWriter.CreateWaveFile(outFile, resampler);
                }
            }
        }

        protected void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            WaveOutEvent outputDevice = null;
            AudioFileReader audioFile = null;
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        protected void Playback()
        {
            WaveOutEvent outputDevice = null;
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            AudioFileReader audioFile = null;
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(
                    @"C:\Users\radvo\Music\Wav - Mp3\looperman-l-2837229-0167183-dr-dre-still-dre-ft-snoop-dogg.wav");
                outputDevice.Init(audioFile);
            }

            outputDevice.Play();
        }

        protected void Mp3ToWav()
        {
            using (var reader = new Mp3FileReader(@"C:\Users\radvo\Music\Wav - Mp3\Stuff (mp3cut.net).mp3"))
            {
                WaveFileWriter.CreateWaveFile(@"C:\Users\radvo\Music\snoop-dogg.wav", reader);
            }
        }

        protected void MixMultipleWAVFilesIntoOne()
        {
            using (var reader1 = new AudioFileReader(@"C:\Users\radvo\Music\Wav - Mp3\70_G_LowFlutes_01_732.wav"))
            using (var reader2 = new AudioFileReader(@"C:\Users\radvo\Music\Wav - Mp3\70_G_NostalgicKeys_02_732.wav"))
            {
                var mixer = new MixingSampleProvider(new[] {reader1, reader2});
                WaveFileWriter.CreateWaveFile16(@"C:\Users\radvo\Music\mixed.wav", mixer);
            }
        }

        protected void MonoToStereo()
        {
            using (var inputReader =
                   new AudioFileReader(
                       @"C:\Users\radvo\Music\Wav - Mp3\looperman-l-2837229-0167183-dr-dre-still-dre-ft-snoop-dogg.wav"))
            {
                var stereo = new MonoToStereoSampleProvider(inputReader);
                stereo.LeftVolume = 0.0f; // silence in left channel
                stereo.RightVolume = 1.0f; // full volume in right channel

                WaveFileWriter.CreateWaveFile16(@"C:\Users\radvo\Music\snoop-dogg.wav", stereo);
            }
        }

        protected void StereoToMono()
        {
            using (var inputReader =
                   new AudioFileReader(
                       @"C:\Users\radvo\Music\Wav - Mp3\looperman-l-2837229-0167183-dr-dre-still-dre-ft-snoop-dogg.wav"))
            {
                var mono = new StereoToMonoSampleProvider(inputReader);
                mono.LeftVolume = 0.0f; // discard the left channel
                mono.RightVolume = 1.0f; // keep the right channel

                WaveFileWriter.CreateWaveFile16(@"C:\Users\radvo\Music\snoop-dogg.wav", mono);
            }
        }

    }
}