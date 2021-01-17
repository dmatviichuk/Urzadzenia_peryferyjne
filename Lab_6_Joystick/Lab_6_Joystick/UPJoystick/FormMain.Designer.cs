namespace UPJoystick
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
			this.comboBoxSelect = new System.Windows.Forms.ComboBox();
			this.labelSelect = new System.Windows.Forms.Label();
			this.buttonEditor = new System.Windows.Forms.Button();
			this.buttonEmulation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxSelect
			// 
			this.comboBoxSelect.FormattingEnabled = true;
			this.comboBoxSelect.Location = new System.Drawing.Point(36, 81);
			this.comboBoxSelect.Name = "comboBoxSelect";
			this.comboBoxSelect.Size = new System.Drawing.Size(306, 21);
			this.comboBoxSelect.TabIndex = 10;
			this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelect_SelectedIndexChanged);
			// 
			// labelSelect
			// 
			this.labelSelect.AutoSize = true;
			this.labelSelect.Location = new System.Drawing.Point(33, 52);
			this.labelSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSelect.Name = "labelSelect";
			this.labelSelect.Size = new System.Drawing.Size(75, 13);
			this.labelSelect.TabIndex = 9;
			this.labelSelect.Text = "Select joystick";
			// 
			// buttonEditor
			// 
			this.buttonEditor.Enabled = false;
			this.buttonEditor.Location = new System.Drawing.Point(380, 112);
			this.buttonEditor.Name = "buttonEditor";
			this.buttonEditor.Size = new System.Drawing.Size(118, 62);
			this.buttonEditor.TabIndex = 7;
			this.buttonEditor.Text = "Paint Emulator";
			this.buttonEditor.UseVisualStyleBackColor = true;
			this.buttonEditor.Click += new System.EventHandler(this.ButtonEditor_Click);
			// 
			// buttonEmulation
			// 
			this.buttonEmulation.Enabled = false;
			this.buttonEmulation.Location = new System.Drawing.Point(380, 28);
			this.buttonEmulation.Name = "buttonEmulation";
			this.buttonEmulation.Size = new System.Drawing.Size(118, 62);
			this.buttonEmulation.TabIndex = 6;
			this.buttonEmulation.Text = "Mouse Emulator";
			this.buttonEmulation.UseVisualStyleBackColor = true;
			this.buttonEmulation.Click += new System.EventHandler(this.ButtonEmulation_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 193);
			this.Controls.Add(this.comboBoxSelect);
			this.Controls.Add(this.labelSelect);
			this.Controls.Add(this.buttonEditor);
			this.Controls.Add(this.buttonEmulation);
			this.Name = "FormMain";
			this.Text = "Direct Input";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Button buttonEditor;
        private System.Windows.Forms.Button buttonEmulation;
    }
}

