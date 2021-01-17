namespace UPJoystick
{
    partial class MouseEmulator
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.buttonStop = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aby zakonczyc naciśnij przycisk na joysticku";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.Location = new System.Drawing.Point(21, 94);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(15, 13);
			this.labelY.TabIndex = 21;
			this.labelY.Text = "y:";
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Location = new System.Drawing.Point(21, 62);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(15, 13);
			this.labelX.TabIndex = 20;
			this.labelX.Text = "x:";
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(107, 145);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 22;
			this.buttonStop.Text = "Start";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MouseEmulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 171);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.labelY);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.label1);
			this.Name = "MouseEmulator";
			this.Text = "MouseEmulator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
    }
}