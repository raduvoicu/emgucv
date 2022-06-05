using System;

namespace LABORATOR6___EmguCV
{
    public partial class Audio : BusinessLogic
    {
        public Audio()
        {
            InitializeComponent();
        }

        private void Audio_Load(object sender, EventArgs e)
        {
        }

        private void concatenateSkipTakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConcatenateThreeAudioFilesAsOne();
        }

        private void pitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pitch();
        }

        private void resamplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resample();
        }

        private void playbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playback();
        }

        private void mP3ToWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mp3ToWav();
        }

        private void mixMultipleWAVFilesIntoOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MixMultipleWAVFilesIntoOne();
        }

        private void monoToStereoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonoToStereo();
        }

        private void stereoToMonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StereoToMono();
        }

    }
}