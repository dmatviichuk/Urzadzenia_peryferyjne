namespace CameraDetector
{
    partial class MyForm
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
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.brightness = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contrast = new System.Windows.Forms.TrackBar();
            this.saturation = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOutput.BackColor = System.Drawing.Color.White;
            this.pictureBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutput.Location = new System.Drawing.Point(9, 99);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(500, 431);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutput.TabIndex = 0;
            this.pictureBoxOutput.TabStop = false;
            this.pictureBoxOutput.Click += new System.EventHandler(this.pictureBoxOutput_Click);
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(12, 25);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(301, 21);
            this.comboBoxDevices.TabIndex = 1;
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(12, 52);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(301, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start / Stop";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 573);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // brightness
            // 
            this.brightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brightness.Location = new System.Drawing.Point(552, 48);
            this.brightness.Maximum = 100;
            this.brightness.Minimum = -100;
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(187, 45);
            this.brightness.TabIndex = 4;
            this.brightness.Scroll += new System.EventHandler(this.BrightnessScroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Capture photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CapturePhoto);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(552, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Capture video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(552, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Move detector";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Change settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select WebCam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(552, 392);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Strona HTML";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contrast";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saturation";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // contrast
            // 
            this.contrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contrast.Location = new System.Drawing.Point(552, 105);
            this.contrast.Maximum = 100;
            this.contrast.Minimum = -100;
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(187, 45);
            this.contrast.TabIndex = 15;
            this.contrast.Scroll += new System.EventHandler(this.contrast_Scroll);
            // 
            // saturation
            // 
            this.saturation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saturation.Location = new System.Drawing.Point(552, 169);
            this.saturation.Maximum = 100;
            this.saturation.Minimum = -100;
            this.saturation.Name = "saturation";
            this.saturation.Size = new System.Drawing.Size(187, 45);
            this.saturation.TabIndex = 16;
            this.saturation.Scroll += new System.EventHandler(this.saturation_Scroll);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 573);
            this.Controls.Add(this.saturation);
            this.Controls.Add(this.contrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.pictureBoxOutput);
            this.Name = "MyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyForm_FormClosing);
            this.Load += new System.EventHandler(this.MyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button buttonStart;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar contrast;
        private System.Windows.Forms.TrackBar saturation;
    }
}

