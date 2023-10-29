namespace GUI_Project
{
    partial class FormMaldives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaldives));
            this.panelMaldives = new System.Windows.Forms.Panel();
            this.pictureBoxMaldives = new System.Windows.Forms.PictureBox();
            this.labelMaldives = new System.Windows.Forms.Label();
            this.labelMaldivesQuote = new System.Windows.Forms.Label();
            this.labelMaldivesDescription = new System.Windows.Forms.Label();
            this.panelMaldives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaldives)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaldives
            // 
            this.panelMaldives.BackColor = System.Drawing.Color.White;
            this.panelMaldives.Controls.Add(this.labelMaldivesDescription);
            this.panelMaldives.Controls.Add(this.labelMaldivesQuote);
            this.panelMaldives.Controls.Add(this.labelMaldives);
            this.panelMaldives.Controls.Add(this.pictureBoxMaldives);
            this.panelMaldives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaldives.Location = new System.Drawing.Point(0, 0);
            this.panelMaldives.Name = "panelMaldives";
            this.panelMaldives.Size = new System.Drawing.Size(711, 396);
            this.panelMaldives.TabIndex = 0;
            // 
            // pictureBoxMaldives
            // 
            this.pictureBoxMaldives.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaldives.Image")));
            this.pictureBoxMaldives.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxMaldives.Name = "pictureBoxMaldives";
            this.pictureBoxMaldives.Size = new System.Drawing.Size(413, 409);
            this.pictureBoxMaldives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaldives.TabIndex = 3;
            this.pictureBoxMaldives.TabStop = false;
            // 
            // labelMaldives
            // 
            this.labelMaldives.AutoSize = true;
            this.labelMaldives.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaldives.Location = new System.Drawing.Point(490, 9);
            this.labelMaldives.Name = "labelMaldives";
            this.labelMaldives.Size = new System.Drawing.Size(155, 38);
            this.labelMaldives.TabIndex = 6;
            this.labelMaldives.Text = "Maldives";
            this.labelMaldives.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaldivesQuote
            // 
            this.labelMaldivesQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaldivesQuote.Location = new System.Drawing.Point(419, 47);
            this.labelMaldivesQuote.Name = "labelMaldivesQuote";
            this.labelMaldivesQuote.Size = new System.Drawing.Size(285, 42);
            this.labelMaldivesQuote.TabIndex = 7;
            this.labelMaldivesQuote.Text = "#The Sunny Side of Life\r\n\r\n";
            // 
            // labelMaldivesDescription
            // 
            this.labelMaldivesDescription.Location = new System.Drawing.Point(421, 80);
            this.labelMaldivesDescription.Name = "labelMaldivesDescription";
            this.labelMaldivesDescription.Size = new System.Drawing.Size(280, 222);
            this.labelMaldivesDescription.TabIndex = 8;
            this.labelMaldivesDescription.Text = resources.GetString("labelMaldivesDescription.Text");
            // 
            // FormMaldives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 396);
            this.Controls.Add(this.panelMaldives);
            this.Name = "FormMaldives";
            this.Text = "FormMaldives";
            this.panelMaldives.ResumeLayout(false);
            this.panelMaldives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaldives)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaldives;
        private System.Windows.Forms.PictureBox pictureBoxMaldives;
        private System.Windows.Forms.Label labelMaldives;
        private System.Windows.Forms.Label labelMaldivesQuote;
        private System.Windows.Forms.Label labelMaldivesDescription;
    }
}