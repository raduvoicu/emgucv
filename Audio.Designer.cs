namespace LABORATOR6___EmguCV
{
    partial class Audio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3ToWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monoToStereoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stereoToMonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.concatenateSkipTakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resamplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playbackToolStripMenuItem,
            this.mP3ToWAVToolStripMenuItem,
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem,
            this.monoToStereoToolStripMenuItem,
            this.stereoToMonoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "Playback";
            this.playbackToolStripMenuItem.Click += new System.EventHandler(this.playbackToolStripMenuItem_Click);
            // 
            // mP3ToWAVToolStripMenuItem
            // 
            this.mP3ToWAVToolStripMenuItem.Name = "mP3ToWAVToolStripMenuItem";
            this.mP3ToWAVToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.mP3ToWAVToolStripMenuItem.Text = "MP3 to WAV";
            this.mP3ToWAVToolStripMenuItem.Click += new System.EventHandler(this.mP3ToWAVToolStripMenuItem_Click);
            // 
            // mixMultipleWAVFilesIntoOneToolStripMenuItem
            // 
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem.Name = "mixMultipleWAVFilesIntoOneToolStripMenuItem";
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem.Text = "Mix multiple WAV files into one";
            this.mixMultipleWAVFilesIntoOneToolStripMenuItem.Click += new System.EventHandler(this.mixMultipleWAVFilesIntoOneToolStripMenuItem_Click);
            // 
            // monoToStereoToolStripMenuItem
            // 
            this.monoToStereoToolStripMenuItem.Name = "monoToStereoToolStripMenuItem";
            this.monoToStereoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.monoToStereoToolStripMenuItem.Text = "Mono to Stereo";
            this.monoToStereoToolStripMenuItem.Click += new System.EventHandler(this.monoToStereoToolStripMenuItem_Click);
            // 
            // stereoToMonoToolStripMenuItem
            // 
            this.stereoToMonoToolStripMenuItem.Name = "stereoToMonoToolStripMenuItem";
            this.stereoToMonoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.stereoToMonoToolStripMenuItem.Text = "Stereo to Mono";
            this.stereoToMonoToolStripMenuItem.Click += new System.EventHandler(this.stereoToMonoToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concatenateSkipTakeToolStripMenuItem,
            this.pitchToolStripMenuItem,
            this.resamplerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // concatenateSkipTakeToolStripMenuItem
            // 
            this.concatenateSkipTakeToolStripMenuItem.Name = "concatenateSkipTakeToolStripMenuItem";
            this.concatenateSkipTakeToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.concatenateSkipTakeToolStripMenuItem.Text = "Concatenate / Skip / Take";
            this.concatenateSkipTakeToolStripMenuItem.Click += new System.EventHandler(this.concatenateSkipTakeToolStripMenuItem_Click);
            // 
            // pitchToolStripMenuItem
            // 
            this.pitchToolStripMenuItem.Name = "pitchToolStripMenuItem";
            this.pitchToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pitchToolStripMenuItem.Text = "Pitch";
            this.pitchToolStripMenuItem.Click += new System.EventHandler(this.pitchToolStripMenuItem_Click);
            // 
            // resamplerToolStripMenuItem
            // 
            this.resamplerToolStripMenuItem.Name = "resamplerToolStripMenuItem";
            this.resamplerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.resamplerToolStripMenuItem.Text = "Resampler";
            this.resamplerToolStripMenuItem.Click += new System.EventHandler(this.resamplerToolStripMenuItem_Click);
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Audio";
            this.Text = "Audio";
            this.Load += new System.EventHandler(this.Audio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3ToWAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixMultipleWAVFilesIntoOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monoToStereoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stereoToMonoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem concatenateSkipTakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resamplerToolStripMenuItem;
    }
}