namespace GUI_Project
{
    partial class FormUAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUAE));
            this.panelUAE = new System.Windows.Forms.Panel();
            this.pictureBoxUAE = new System.Windows.Forms.PictureBox();
            this.labelUAE = new System.Windows.Forms.Label();
            this.labelUAEQuote = new System.Windows.Forms.Label();
            this.labelUAEDescription = new System.Windows.Forms.Label();
            this.panelUAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUAE
            // 
            this.panelUAE.BackColor = System.Drawing.Color.White;
            this.panelUAE.Controls.Add(this.labelUAEDescription);
            this.panelUAE.Controls.Add(this.labelUAEQuote);
            this.panelUAE.Controls.Add(this.labelUAE);
            this.panelUAE.Controls.Add(this.pictureBoxUAE);
            this.panelUAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUAE.Location = new System.Drawing.Point(0, 0);
            this.panelUAE.Name = "panelUAE";
            this.panelUAE.Size = new System.Drawing.Size(710, 389);
            this.panelUAE.TabIndex = 0;
            // 
            // pictureBoxUAE
            // 
            this.pictureBoxUAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUAE.Image")));
            this.pictureBoxUAE.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUAE.Name = "pictureBoxUAE";
            this.pictureBoxUAE.Size = new System.Drawing.Size(347, 389);
            this.pictureBoxUAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUAE.TabIndex = 0;
            this.pictureBoxUAE.TabStop = false;
            // 
            // labelUAE
            // 
            this.labelUAE.AutoSize = true;
            this.labelUAE.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUAE.Location = new System.Drawing.Point(454, 9);
            this.labelUAE.Name = "labelUAE";
            this.labelUAE.Size = new System.Drawing.Size(100, 38);
            this.labelUAE.TabIndex = 1;
            this.labelUAE.Text = "U.A.E";
            this.labelUAE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUAEQuote
            // 
            this.labelUAEQuote.AutoSize = true;
            this.labelUAEQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUAEQuote.Location = new System.Drawing.Point(353, 56);
            this.labelUAEQuote.Name = "labelUAEQuote";
            this.labelUAEQuote.Size = new System.Drawing.Size(270, 25);
            this.labelUAEQuote.TabIndex = 2;
            this.labelUAEQuote.Text = "#One summer isn\'t enough";
            // 
            // labelUAEDescription
            // 
            this.labelUAEDescription.Location = new System.Drawing.Point(355, 93);
            this.labelUAEDescription.Name = "labelUAEDescription";
            this.labelUAEDescription.Size = new System.Drawing.Size(328, 196);
            this.labelUAEDescription.TabIndex = 3;
            this.labelUAEDescription.Text = resources.GetString("labelUAEDescription.Text");
            // 
            // FormUAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 389);
            this.Controls.Add(this.panelUAE);
            this.Name = "FormUAE";
            this.Text = "FormUAE";
            this.panelUAE.ResumeLayout(false);
            this.panelUAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUAE;
        private System.Windows.Forms.PictureBox pictureBoxUAE;
        private System.Windows.Forms.Label labelUAE;
        private System.Windows.Forms.Label labelUAEDescription;
        private System.Windows.Forms.Label labelUAEQuote;
    }
}