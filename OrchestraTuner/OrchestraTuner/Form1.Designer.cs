namespace OrchestraTuner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.scaleBox = new System.Windows.Forms.PictureBox();
            this.handBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.freqLabel = new System.Windows.Forms.Label();
            this.baseFreqLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baseFreqTrackBar = new System.Windows.Forms.TrackBar();
            this.updateInstrumentButton = new System.Windows.Forms.Button();
            this.deleteBandButton = new System.Windows.Forms.Button();
            this.updateBand = new System.Windows.Forms.Button();
            this.addBandButton = new System.Windows.Forms.Button();
            this.deleteInstrumentButton = new System.Windows.Forms.Button();
            this.addInstrumentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.bandSelect = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseFreqTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 719);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(197, 35);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "440";
            // 
            // scaleBox
            // 
            this.scaleBox.BackColor = System.Drawing.Color.Transparent;
            this.scaleBox.Location = new System.Drawing.Point(220, 206);
            this.scaleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(749, 750);
            this.scaleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scaleBox.TabIndex = 1;
            this.scaleBox.TabStop = false;
            // 
            // handBox
            // 
            this.handBox.BackColor = System.Drawing.Color.Transparent;
            this.handBox.Location = new System.Drawing.Point(220, 228);
            this.handBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handBox.Name = "handBox";
            this.handBox.Size = new System.Drawing.Size(749, 750);
            this.handBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handBox.TabIndex = 2;
            this.handBox.TabStop = false;
            this.handBox.Click += new System.EventHandler(this.handBox_Click);
            // 
            // dotBox
            // 
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(220, 257);
            this.dotBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(749, 750);
            this.dotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dotBox.TabIndex = 3;
            this.dotBox.TabStop = false;
            this.dotBox.Click += new System.EventHandler(this.dotBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.baseFreqLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.baseFreqTrackBar);
            this.panel1.Controls.Add(this.updateInstrumentButton);
            this.panel1.Controls.Add(this.deleteBandButton);
            this.panel1.Controls.Add(this.updateBand);
            this.panel1.Controls.Add(this.addBandButton);
            this.panel1.Controls.Add(this.deleteInstrumentButton);
            this.panel1.Controls.Add(this.addInstrumentButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.instrumentList);
            this.panel1.Controls.Add(this.bandSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 800);
            this.panel1.TabIndex = 4;
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.freqLabel.Location = new System.Drawing.Point(484, 124);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(64, 25);
            this.freqLabel.TabIndex = 15;
            this.freqLabel.Text = "label5";
            // 
            // baseFreqLabel
            // 
            this.baseFreqLabel.AutoSize = true;
            this.baseFreqLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baseFreqLabel.Location = new System.Drawing.Point(81, 598);
            this.baseFreqLabel.Name = "baseFreqLabel";
            this.baseFreqLabel.Size = new System.Drawing.Size(46, 17);
            this.baseFreqLabel.TabIndex = 14;
            this.baseFreqLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Base freq: ";
            // 
            // baseFreqTrackBar
            // 
            this.baseFreqTrackBar.Location = new System.Drawing.Point(17, 559);
            this.baseFreqTrackBar.Name = "baseFreqTrackBar";
            this.baseFreqTrackBar.Size = new System.Drawing.Size(168, 56);
            this.baseFreqTrackBar.TabIndex = 12;
            this.baseFreqTrackBar.ValueChanged += new System.EventHandler(this.baseFreqTrackBar_ValueChanged);
            // 
            // updateInstrumentButton
            // 
            this.updateInstrumentButton.Location = new System.Drawing.Point(17, 479);
            this.updateInstrumentButton.Name = "updateInstrumentButton";
            this.updateInstrumentButton.Size = new System.Drawing.Size(75, 23);
            this.updateInstrumentButton.TabIndex = 11;
            this.updateInstrumentButton.Text = "Update";
            this.updateInstrumentButton.UseVisualStyleBackColor = true;
            this.updateInstrumentButton.Click += new System.EventHandler(this.updateInstrumentButton_Click);
            // 
            // deleteBandButton
            // 
            this.deleteBandButton.Location = new System.Drawing.Point(110, 508);
            this.deleteBandButton.Name = "deleteBandButton";
            this.deleteBandButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBandButton.TabIndex = 10;
            this.deleteBandButton.Text = "Delete";
            this.deleteBandButton.UseVisualStyleBackColor = true;
            this.deleteBandButton.Click += new System.EventHandler(this.deleteBandButton_Click);
            // 
            // updateBand
            // 
            this.updateBand.Location = new System.Drawing.Point(110, 479);
            this.updateBand.Name = "updateBand";
            this.updateBand.Size = new System.Drawing.Size(75, 23);
            this.updateBand.TabIndex = 9;
            this.updateBand.Text = "Update";
            this.updateBand.UseVisualStyleBackColor = true;
            this.updateBand.Click += new System.EventHandler(this.updateBand_Click);
            // 
            // addBandButton
            // 
            this.addBandButton.Location = new System.Drawing.Point(110, 450);
            this.addBandButton.Name = "addBandButton";
            this.addBandButton.Size = new System.Drawing.Size(75, 23);
            this.addBandButton.TabIndex = 8;
            this.addBandButton.Text = "Add";
            this.addBandButton.UseVisualStyleBackColor = true;
            this.addBandButton.Click += new System.EventHandler(this.addBandButton_Click);
            // 
            // deleteInstrumentButton
            // 
            this.deleteInstrumentButton.Location = new System.Drawing.Point(17, 508);
            this.deleteInstrumentButton.Name = "deleteInstrumentButton";
            this.deleteInstrumentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteInstrumentButton.TabIndex = 7;
            this.deleteInstrumentButton.Text = "Delete";
            this.deleteInstrumentButton.UseVisualStyleBackColor = true;
            this.deleteInstrumentButton.Click += new System.EventHandler(this.deleteInstrumentButton_Click);
            // 
            // addInstrumentButton
            // 
            this.addInstrumentButton.Location = new System.Drawing.Point(16, 450);
            this.addInstrumentButton.Name = "addInstrumentButton";
            this.addInstrumentButton.Size = new System.Drawing.Size(75, 23);
            this.addInstrumentButton.TabIndex = 6;
            this.addInstrumentButton.Text = "Add";
            this.addInstrumentButton.UseVisualStyleBackColor = true;
            this.addInstrumentButton.Click += new System.EventHandler(this.addInstrumentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(137, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Instruments";
            // 
            // instrumentList
            // 
            this.instrumentList.FormattingEnabled = true;
            this.instrumentList.ItemHeight = 16;
            this.instrumentList.Location = new System.Drawing.Point(17, 124);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(168, 276);
            this.instrumentList.TabIndex = 3;
            this.instrumentList.SelectedIndexChanged += new System.EventHandler(this.instrumentList_SelectedIndexChanged);
            // 
            // bandSelect
            // 
            this.bandSelect.FormattingEnabled = true;
            this.bandSelect.Location = new System.Drawing.Point(17, 94);
            this.bandSelect.Name = "bandSelect";
            this.bandSelect.Size = new System.Drawing.Size(168, 24);
            this.bandSelect.TabIndex = 2;
            this.bandSelect.Text = "--Select band--";
            this.bandSelect.SelectedIndexChanged += new System.EventHandler(this.bandSelect_SelectedIndexChanged);
            this.bandSelect.Enter += new System.EventHandler(this.bandSelect_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 89);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orchestra Tuner";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 89);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(624, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(206, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Instrument tuning frequency:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 692);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Heard frequency:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(981, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.freqLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.handBox);
            this.Controls.Add(this.scaleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseFreqTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox scaleBox;
        private System.Windows.Forms.PictureBox handBox;
        private System.Windows.Forms.PictureBox dotBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bandSelect;
        private System.Windows.Forms.ListBox instrumentList;
        private System.Windows.Forms.Button updateBand;
        private System.Windows.Forms.Button addBandButton;
        private System.Windows.Forms.Button deleteInstrumentButton;
        private System.Windows.Forms.Button addInstrumentButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBandButton;
        private System.Windows.Forms.Button updateInstrumentButton;
        private System.Windows.Forms.TrackBar baseFreqTrackBar;
        private System.Windows.Forms.Label baseFreqLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

