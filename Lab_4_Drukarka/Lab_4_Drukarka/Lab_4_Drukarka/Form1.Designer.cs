namespace Lab_4_Drukarka
{
	partial class MainWindow
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
			this.buttonPrint = new System.Windows.Forms.Button();
			this.serialPortPrinter = new System.IO.Ports.SerialPort(this.components);
			this.comboBoxFont = new System.Windows.Forms.ComboBox();
			this.labelFont = new System.Windows.Forms.Label();
			this.labelSize = new System.Windows.Forms.Label();
			this.comboBoxSize = new System.Windows.Forms.ComboBox();
			this.checkBoxBold = new System.Windows.Forms.CheckBox();
			this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
			this.checkBoxPrint = new System.Windows.Forms.CheckBox();
			this.printDocumentPage = new System.Drawing.Printing.PrintDocument();
			this.checkBoxItalic = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(75, 127);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 0;
			this.buttonPrint.Text = "Drukuj";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// serialPortPrinter
			// 
			this.serialPortPrinter.PortName = "LPT3";
			// 
			// comboBoxFont
			// 
			this.comboBoxFont.FormattingEnabled = true;
			this.comboBoxFont.Items.AddRange(new object[] {
            "Arial",
            "TimesNewRoman",
            "Comic Sans MS"});
			this.comboBoxFont.Location = new System.Drawing.Point(75, 7);
			this.comboBoxFont.Name = "comboBoxFont";
			this.comboBoxFont.Size = new System.Drawing.Size(100, 21);
			this.comboBoxFont.TabIndex = 3;
			// 
			// labelFont
			// 
			this.labelFont.AutoSize = true;
			this.labelFont.Location = new System.Drawing.Point(10, 10);
			this.labelFont.Name = "labelFont";
			this.labelFont.Size = new System.Drawing.Size(54, 13);
			this.labelFont.TabIndex = 5;
			this.labelFont.Text = "Czcionka:";
			// 
			// labelSize
			// 
			this.labelSize.AutoSize = true;
			this.labelSize.Location = new System.Drawing.Point(10, 34);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(51, 13);
			this.labelSize.TabIndex = 7;
			this.labelSize.Text = "Rozmiar: ";
			// 
			// comboBoxSize
			// 
			this.comboBoxSize.FormattingEnabled = true;
			this.comboBoxSize.Items.AddRange(new object[] {
            "Duzy",
            "Sredni",
            "Maly"});
			this.comboBoxSize.Location = new System.Drawing.Point(75, 31);
			this.comboBoxSize.Name = "comboBoxSize";
			this.comboBoxSize.Size = new System.Drawing.Size(100, 21);
			this.comboBoxSize.TabIndex = 8;
			this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
			// 
			// checkBoxBold
			// 
			this.checkBoxBold.AutoSize = true;
			this.checkBoxBold.Location = new System.Drawing.Point(75, 58);
			this.checkBoxBold.Name = "checkBoxBold";
			this.checkBoxBold.Size = new System.Drawing.Size(82, 17);
			this.checkBoxBold.TabIndex = 9;
			this.checkBoxBold.Text = "Pogrubienie";
			this.checkBoxBold.UseVisualStyleBackColor = true;
			// 
			// checkBoxUnderline
			// 
			this.checkBoxUnderline.AutoSize = true;
			this.checkBoxUnderline.Location = new System.Drawing.Point(75, 81);
			this.checkBoxUnderline.Name = "checkBoxUnderline";
			this.checkBoxUnderline.Size = new System.Drawing.Size(87, 17);
			this.checkBoxUnderline.TabIndex = 10;
			this.checkBoxUnderline.Text = "Podkreslenie";
			this.checkBoxUnderline.UseVisualStyleBackColor = true;
			// 
			// checkBoxPrint
			// 
			this.checkBoxPrint.AutoSize = true;
			this.checkBoxPrint.Location = new System.Drawing.Point(192, 12);
			this.checkBoxPrint.Name = "checkBoxPrint";
			this.checkBoxPrint.Size = new System.Drawing.Size(98, 17);
			this.checkBoxPrint.TabIndex = 11;
			this.checkBoxPrint.Text = "Drukuj obrazek";
			this.checkBoxPrint.UseVisualStyleBackColor = true;
			// 
			// printDocumentPage
			// 
			this.printDocumentPage.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
			// 
			// checkBoxItalic
			// 
			this.checkBoxItalic.AutoSize = true;
			this.checkBoxItalic.Location = new System.Drawing.Point(75, 104);
			this.checkBoxItalic.Name = "checkBoxItalic";
			this.checkBoxItalic.Size = new System.Drawing.Size(66, 17);
			this.checkBoxItalic.TabIndex = 12;
			this.checkBoxItalic.Text = "Kursywa";
			this.checkBoxItalic.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 166);
			this.Controls.Add(this.checkBoxItalic);
			this.Controls.Add(this.checkBoxPrint);
			this.Controls.Add(this.checkBoxUnderline);
			this.Controls.Add(this.checkBoxBold);
			this.Controls.Add(this.comboBoxSize);
			this.Controls.Add(this.labelSize);
			this.Controls.Add(this.labelFont);
			this.Controls.Add(this.comboBoxFont);
			this.Controls.Add(this.buttonPrint);
			this.Name = "MainWindow";
			this.Text = "Okno glowne";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonPrint;
		public System.IO.Ports.SerialPort serialPortPrinter;
		private System.Windows.Forms.ComboBox comboBoxFont;
		private System.Windows.Forms.Label labelFont;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.ComboBox comboBoxSize;
		private System.Windows.Forms.CheckBox checkBoxBold;
		private System.Windows.Forms.CheckBox checkBoxUnderline;
		private System.Windows.Forms.CheckBox checkBoxItalic;
		private System.Windows.Forms.CheckBox checkBoxPrint;
		private System.Drawing.Printing.PrintDocument printDocumentPage;

	}
}

