namespace GUI_Project
{
    partial class FormIndia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUAE = new System.Windows.Forms.PictureBox();
            this.labelNepal = new System.Windows.Forms.Label();
            this.labelNepalQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNepalQuote);
            this.panel1.Controls.Add(this.labelNepal);
            this.panel1.Controls.Add(this.pictureBoxUAE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 394);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxUAE
            // 
            this.pictureBoxUAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUAE.Image")));
            this.pictureBoxUAE.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUAE.Name = "pictureBoxUAE";
            this.pictureBoxUAE.Size = new System.Drawing.Size(410, 394);
            this.pictureBoxUAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUAE.TabIndex = 1;
            this.pictureBoxUAE.TabStop = false;
            // 
            // labelNepal
            // 
            this.labelNepal.AutoSize = true;
            this.labelNepal.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNepal.Location = new System.Drawing.Point(499, 9);
            this.labelNepal.Name = "labelNepal";
            this.labelNepal.Size = new System.Drawing.Size(95, 38);
            this.labelNepal.TabIndex = 4;
            this.labelNepal.Text = "India";
            this.labelNepal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNepalQuote
            // 
            this.labelNepalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNepalQuote.Location = new System.Drawing.Point(414, 47);
            this.labelNepalQuote.Name = "labelNepalQuote";
            this.labelNepalQuote.Size = new System.Drawing.Size(285, 55);
            this.labelNepalQuote.TabIndex = 5;
            this.labelNepalQuote.Text = "#Immerse Yourself into Rich Culture\r\n";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(416, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 192);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormIndia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.panel1);
            this.Name = "FormIndia";
            this.Text = "FormIndia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxUAE;
        private System.Windows.Forms.Label labelNepal;
        private System.Windows.Forms.Label labelNepalQuote;
        private System.Windows.Forms.Label label1;
    }
}