namespace GUI_Project
{
    partial class FormBhutan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBhutan));
            this.panelBhutan = new System.Windows.Forms.Panel();
            this.pictureBoxBhutan = new System.Windows.Forms.PictureBox();
            this.labelBhutan = new System.Windows.Forms.Label();
            this.labelBhutanQuote = new System.Windows.Forms.Label();
            this.labelBhutanDescription = new System.Windows.Forms.Label();
            this.panelBhutan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBhutan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBhutan
            // 
            this.panelBhutan.BackColor = System.Drawing.Color.White;
            this.panelBhutan.Controls.Add(this.labelBhutanDescription);
            this.panelBhutan.Controls.Add(this.labelBhutanQuote);
            this.panelBhutan.Controls.Add(this.labelBhutan);
            this.panelBhutan.Controls.Add(this.pictureBoxBhutan);
            this.panelBhutan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBhutan.Location = new System.Drawing.Point(0, 0);
            this.panelBhutan.Name = "panelBhutan";
            this.panelBhutan.Size = new System.Drawing.Size(714, 391);
            this.panelBhutan.TabIndex = 0;
            // 
            // pictureBoxBhutan
            // 
            this.pictureBoxBhutan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBhutan.Image")));
            this.pictureBoxBhutan.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBhutan.Name = "pictureBoxBhutan";
            this.pictureBoxBhutan.Size = new System.Drawing.Size(402, 391);
            this.pictureBoxBhutan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBhutan.TabIndex = 2;
            this.pictureBoxBhutan.TabStop = false;
            // 
            // labelBhutan
            // 
            this.labelBhutan.AutoSize = true;
            this.labelBhutan.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBhutan.Location = new System.Drawing.Point(494, 9);
            this.labelBhutan.Name = "labelBhutan";
            this.labelBhutan.Size = new System.Drawing.Size(123, 38);
            this.labelBhutan.TabIndex = 5;
            this.labelBhutan.Text = "Bhutan";
            this.labelBhutan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBhutanQuote
            // 
            this.labelBhutanQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBhutanQuote.Location = new System.Drawing.Point(408, 47);
            this.labelBhutanQuote.Name = "labelBhutanQuote";
            this.labelBhutanQuote.Size = new System.Drawing.Size(285, 42);
            this.labelBhutanQuote.TabIndex = 6;
            this.labelBhutanQuote.Text = "#Unravel the History";
            // 
            // labelBhutanDescription
            // 
            this.labelBhutanDescription.Location = new System.Drawing.Point(410, 89);
            this.labelBhutanDescription.Name = "labelBhutanDescription";
            this.labelBhutanDescription.Size = new System.Drawing.Size(280, 222);
            this.labelBhutanDescription.TabIndex = 7;
            this.labelBhutanDescription.Text = resources.GetString("labelBhutanDescription.Text");
            // 
            // FormBhutan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 391);
            this.Controls.Add(this.panelBhutan);
            this.Name = "FormBhutan";
            this.Text = "FormBhutan";
            this.panelBhutan.ResumeLayout(false);
            this.panelBhutan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBhutan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBhutan;
        private System.Windows.Forms.PictureBox pictureBoxBhutan;
        private System.Windows.Forms.Label labelBhutan;
        private System.Windows.Forms.Label labelBhutanQuote;
        private System.Windows.Forms.Label labelBhutanDescription;
    }
}