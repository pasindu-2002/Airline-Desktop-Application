namespace GUI_Project
{
    partial class FormSriLanka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSriLanka));
            this.panelSriLanka = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSriLanka = new System.Windows.Forms.Label();
            this.labelSriLankaQuote = new System.Windows.Forms.Label();
            this.labelSriLankaDescription = new System.Windows.Forms.Label();
            this.panelSriLanka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSriLanka
            // 
            this.panelSriLanka.BackColor = System.Drawing.Color.White;
            this.panelSriLanka.Controls.Add(this.labelSriLankaDescription);
            this.panelSriLanka.Controls.Add(this.labelSriLankaQuote);
            this.panelSriLanka.Controls.Add(this.labelSriLanka);
            this.panelSriLanka.Controls.Add(this.pictureBox1);
            this.panelSriLanka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSriLanka.Location = new System.Drawing.Point(0, 0);
            this.panelSriLanka.Name = "panelSriLanka";
            this.panelSriLanka.Size = new System.Drawing.Size(708, 393);
            this.panelSriLanka.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSriLanka
            // 
            this.labelSriLanka.AutoSize = true;
            this.labelSriLanka.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSriLanka.Location = new System.Drawing.Point(496, 9);
            this.labelSriLanka.Name = "labelSriLanka";
            this.labelSriLanka.Size = new System.Drawing.Size(156, 38);
            this.labelSriLanka.TabIndex = 2;
            this.labelSriLanka.Text = "Sri Lanka";
            this.labelSriLanka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSriLankaQuote
            // 
            this.labelSriLankaQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSriLankaQuote.Location = new System.Drawing.Point(439, 47);
            this.labelSriLankaQuote.Name = "labelSriLankaQuote";
            this.labelSriLankaQuote.Size = new System.Drawing.Size(257, 59);
            this.labelSriLankaQuote.TabIndex = 3;
            this.labelSriLankaQuote.Text = "#The Gem of the Indian Ocean";
            // 
            // labelSriLankaDescription
            // 
            this.labelSriLankaDescription.Location = new System.Drawing.Point(441, 106);
            this.labelSriLankaDescription.Name = "labelSriLankaDescription";
            this.labelSriLankaDescription.Size = new System.Drawing.Size(242, 211);
            this.labelSriLankaDescription.TabIndex = 4;
            this.labelSriLankaDescription.Text = resources.GetString("labelSriLankaDescription.Text");
            // 
            // FormSriLanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 393);
            this.Controls.Add(this.panelSriLanka);
            this.Name = "FormSriLanka";
            this.Text = "FormSriLanka";
            this.panelSriLanka.ResumeLayout(false);
            this.panelSriLanka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSriLanka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSriLanka;
        private System.Windows.Forms.Label labelSriLankaDescription;
        private System.Windows.Forms.Label labelSriLankaQuote;
    }
}