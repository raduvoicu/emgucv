namespace LABORATOR6___EmguCV
{
    partial class Base
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
            this.uploadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.convertToGrayScale = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showImageHistogram = new System.Windows.Forms.Button();
            this.changeBrigthnessAndContrast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.exitBbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gamaCorrect = new System.Windows.Forms.Button();
            this.gammaCoefficient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resizeCoefficient = new System.Windows.Forms.TextBox();
            this.imageResize = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.imageRotate = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.extractRegionOfInterest = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.videoForm = new System.Windows.Forms.Button();
            this.blend = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.watermark = new System.Windows.Forms.Button();
            this.audioButton = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(12, 12);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(150, 23);
            this.uploadImage.TabIndex = 0;
            this.uploadImage.Text = "Press to Upload";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.UploadImage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // convertToGrayScale
            // 
            this.convertToGrayScale.Location = new System.Drawing.Point(12, 41);
            this.convertToGrayScale.Name = "convertToGrayScale";
            this.convertToGrayScale.Size = new System.Drawing.Size(153, 23);
            this.convertToGrayScale.TabIndex = 2;
            this.convertToGrayScale.Text = "Convert to Grayscale";
            this.convertToGrayScale.UseVisualStyleBackColor = true;
            this.convertToGrayScale.Click += new System.EventHandler(this.ConvertToGrayScale);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(193, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // showImageHistogram
            // 
            this.showImageHistogram.Location = new System.Drawing.Point(12, 70);
            this.showImageHistogram.Name = "showImageHistogram";
            this.showImageHistogram.Size = new System.Drawing.Size(150, 23);
            this.showImageHistogram.TabIndex = 4;
            this.showImageHistogram.Text = "Show Histogram";
            this.showImageHistogram.UseVisualStyleBackColor = true;
            this.showImageHistogram.Click += new System.EventHandler(this.ShowImageHistogram);
            // 
            // changeBrigthnessAndContrast
            // 
            this.changeBrigthnessAndContrast.Location = new System.Drawing.Point(12, 99);
            this.changeBrigthnessAndContrast.Name = "changeBrigthnessAndContrast";
            this.changeBrigthnessAndContrast.Size = new System.Drawing.Size(153, 23);
            this.changeBrigthnessAndContrast.TabIndex = 6;
            this.changeBrigthnessAndContrast.Text = "Change Brightness/ Contrast";
            this.changeBrigthnessAndContrast.UseVisualStyleBackColor = true;
            this.changeBrigthnessAndContrast.Click += new System.EventHandler(this.ChangeBrightnessAndContrast);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitBbutton
            // 
            this.exitBbutton.Location = new System.Drawing.Point(1772, 918);
            this.exitBbutton.Name = "exitBbutton";
            this.exitBbutton.Size = new System.Drawing.Size(75, 23);
            this.exitBbutton.TabIndex = 9;
            this.exitBbutton.Text = "Exit";
            this.exitBbutton.UseVisualStyleBackColor = true;
            this.exitBbutton.Click += new System.EventHandler(this.Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contrast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Brightness";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(714, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(438, 225);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // gamaCorrect
            // 
            this.gamaCorrect.Location = new System.Drawing.Point(12, 199);
            this.gamaCorrect.Name = "gamaCorrect";
            this.gamaCorrect.Size = new System.Drawing.Size(129, 23);
            this.gamaCorrect.TabIndex = 13;
            this.gamaCorrect.Text = "Gamma Corection";
            this.gamaCorrect.UseVisualStyleBackColor = true;
            this.gamaCorrect.Click += new System.EventHandler(this.GamaCorrect);
            // 
            // gammaCoefficient
            // 
            this.gammaCoefficient.Location = new System.Drawing.Point(12, 251);
            this.gammaCoefficient.Name = "gammaCoefficient";
            this.gammaCoefficient.Size = new System.Drawing.Size(150, 20);
            this.gammaCoefficient.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter gamma coefficient";
            // 
            // resizeCoefficient
            // 
            this.resizeCoefficient.Location = new System.Drawing.Point(15, 315);
            this.resizeCoefficient.Name = "resizeCoefficient";
            this.resizeCoefficient.Size = new System.Drawing.Size(147, 20);
            this.resizeCoefficient.TabIndex = 16;
            // 
            // imageResize
            // 
            this.imageResize.Location = new System.Drawing.Point(15, 286);
            this.imageResize.Name = "imageResize";
            this.imageResize.Size = new System.Drawing.Size(147, 23);
            this.imageResize.TabIndex = 17;
            this.imageResize.Text = "Resize image";
            this.imageResize.UseVisualStyleBackColor = true;
            this.imageResize.Click += new System.EventHandler(this.ImageResize);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(987, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(516, 247);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // imageRotate
            // 
            this.imageRotate.Location = new System.Drawing.Point(15, 351);
            this.imageRotate.Name = "imageRotate";
            this.imageRotate.Size = new System.Drawing.Size(147, 23);
            this.imageRotate.TabIndex = 19;
            this.imageRotate.Text = "Rotate";
            this.imageRotate.UseVisualStyleBackColor = true;
            this.imageRotate.Click += new System.EventHandler(this.ImageRotate);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(15, 387);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(147, 20);
            this.angle.TabIndex = 20;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(1158, 265);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(254, 225);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(193, 496);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(291, 300);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCroppedRegionOfInterest);
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownOnImage);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveThroughImage);
            this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpFromImage);
            // 
            // extractRegionOfInterest
            // 
            this.extractRegionOfInterest.Location = new System.Drawing.Point(15, 426);
            this.extractRegionOfInterest.Name = "extractRegionOfInterest";
            this.extractRegionOfInterest.Size = new System.Drawing.Size(147, 23);
            this.extractRegionOfInterest.TabIndex = 23;
            this.extractRegionOfInterest.Text = "ROI";
            this.extractRegionOfInterest.UseVisualStyleBackColor = true;
            this.extractRegionOfInterest.Click += new System.EventHandler(this.ExtractRegionOfInterest);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(490, 496);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(275, 300);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // videoForm
            // 
            this.videoForm.Location = new System.Drawing.Point(15, 467);
            this.videoForm.Name = "videoForm";
            this.videoForm.Size = new System.Drawing.Size(147, 23);
            this.videoForm.TabIndex = 25;
            this.videoForm.Text = "Video Form";
            this.videoForm.UseVisualStyleBackColor = true;
            this.videoForm.Click += new System.EventHandler(this.LoadFormForVideo);
            // 
            // blend
            // 
            this.blend.Location = new System.Drawing.Point(15, 497);
            this.blend.Name = "blend";
            this.blend.Size = new System.Drawing.Size(147, 23);
            this.blend.TabIndex = 27;
            this.blend.Text = "Blending";
            this.blend.UseVisualStyleBackColor = true;
            this.blend.Click += new System.EventHandler(this.Blending);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(1106, 497);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(306, 299);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            // 
            // watermark
            // 
            this.watermark.Location = new System.Drawing.Point(15, 527);
            this.watermark.Name = "watermark";
            this.watermark.Size = new System.Drawing.Size(147, 23);
            this.watermark.TabIndex = 29;
            this.watermark.Text = "Watermark";
            this.watermark.UseVisualStyleBackColor = true;
            this.watermark.Click += new System.EventHandler(this.Watermark);
            // 
            // audioButton
            // 
            this.audioButton.Location = new System.Drawing.Point(15, 557);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(147, 23);
            this.audioButton.TabIndex = 30;
            this.audioButton.Text = "Audio Form";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.LoadFormForAudio);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(772, 497);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(327, 299);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 953);
            this.Controls.Add(this.audioButton);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.blend);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.videoForm);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.extractRegionOfInterest);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.imageRotate);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.imageResize);
            this.Controls.Add(this.resizeCoefficient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gammaCoefficient);
            this.Controls.Add(this.gamaCorrect);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changeBrigthnessAndContrast);
            this.Controls.Add(this.showImageHistogram);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.convertToGrayScale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uploadImage);
            this.Name = "Base";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button convertToGrayScale;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button showImageHistogram;
        private System.Windows.Forms.Button changeBrigthnessAndContrast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button exitBbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button gamaCorrect;
        private System.Windows.Forms.TextBox gammaCoefficient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resizeCoefficient;
        private System.Windows.Forms.Button imageResize;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button imageRotate;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button extractRegionOfInterest;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button videoForm;
        private System.Windows.Forms.Button blend;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button watermark;
        private System.Windows.Forms.Button audioButton;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

