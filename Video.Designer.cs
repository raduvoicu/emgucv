namespace LABORATOR6___EmguCV
{
    partial class Video
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
            this.videoLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoVideoLoad = new System.Windows.Forms.Button();
            this.abruptMerge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoLoad
            // 
            this.videoLoad.Location = new System.Drawing.Point(13, 13);
            this.videoLoad.Name = "videoLoad";
            this.videoLoad.Size = new System.Drawing.Size(94, 23);
            this.videoLoad.TabIndex = 0;
            this.videoLoad.Text = "Load Video";
            this.videoLoad.UseVisualStyleBackColor = true;
            this.videoLoad.Click += new System.EventHandler(this.VideoLoad);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1669, 860);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // autoVideoLoad
            // 
            this.autoVideoLoad.Location = new System.Drawing.Point(12, 38);
            this.autoVideoLoad.Name = "autoVideoLoad";
            this.autoVideoLoad.Size = new System.Drawing.Size(95, 23);
            this.autoVideoLoad.TabIndex = 3;
            this.autoVideoLoad.Text = "Auto Load Video";
            this.autoVideoLoad.UseVisualStyleBackColor = true;
            this.autoVideoLoad.Click += new System.EventHandler(this.autoVideoLoad_Click);
            // 
            // abruptMerge
            // 
            this.abruptMerge.Location = new System.Drawing.Point(16, 68);
            this.abruptMerge.Name = "abruptMerge";
            this.abruptMerge.Size = new System.Drawing.Size(91, 23);
            this.abruptMerge.TabIndex = 4;
            this.abruptMerge.Text = "Merge abrupt";
            this.abruptMerge.UseVisualStyleBackColor = true;
            this.abruptMerge.Click += new System.EventHandler(this.AbruptMerge);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 885);
            this.Controls.Add(this.abruptMerge);
            this.Controls.Add(this.autoVideoLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoLoad);
            this.Name = "Video";
            this.Text = "Video";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button videoLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autoVideoLoad;
        private System.Windows.Forms.Button abruptMerge;
    }
}