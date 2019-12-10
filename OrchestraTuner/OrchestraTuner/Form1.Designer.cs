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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.scaleBox = new System.Windows.Forms.PictureBox();
            this.handBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(436, 768);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(220, 35);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "440";
            // 
            // scaleBox
            // 
            this.scaleBox.BackColor = System.Drawing.Color.Transparent;
            this.scaleBox.Location = new System.Drawing.Point(220, 12);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(750, 750);
            this.scaleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scaleBox.TabIndex = 1;
            this.scaleBox.TabStop = false;
            // 
            // handBox
            // 
            this.handBox.BackColor = System.Drawing.Color.Transparent;
            this.handBox.Location = new System.Drawing.Point(240, 12);
            this.handBox.Name = "handBox";
            this.handBox.Size = new System.Drawing.Size(750, 750);
            this.handBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handBox.TabIndex = 2;
            this.handBox.TabStop = false;
            this.handBox.Click += new System.EventHandler(this.handBox_Click);
            // 
            // dotBox
            // 
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(408, 12);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(750, 750);
            this.dotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dotBox.TabIndex = 3;
            this.dotBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.handBox);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox scaleBox;
        private System.Windows.Forms.PictureBox handBox;
        private System.Windows.Forms.PictureBox dotBox;
    }
}

