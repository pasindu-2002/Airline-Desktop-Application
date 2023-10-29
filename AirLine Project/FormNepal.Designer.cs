namespace GUI_Project
{
    partial class FormNepal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNepal));
            this.panelNepal = new System.Windows.Forms.Panel();
            this.pictureBoxUAE = new System.Windows.Forms.PictureBox();
            this.labelNepal = new System.Windows.Forms.Label();
            this.labelNepalQuote = new System.Windows.Forms.Label();
            this.labelNepalDescription = new System.Windows.Forms.Label();
            this.panelNepal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNepal
            // 
            this.panelNepal.BackColor = System.Drawing.Color.White;
            this.panelNepal.Controls.Add(this.labelNepalDescription);
            this.panelNepal.Controls.Add(this.labelNepalQuote);
            this.panelNepal.Controls.Add(this.labelNepal);
            this.panelNepal.Controls.Add(this.pictureBoxUAE);
            this.panelNepal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNepal.Location = new System.Drawing.Point(0, 0);
            this.panelNepal.Name = "panelNepal";
            this.panelNepal.Size = new System.Drawing.Size(717, 392);
            this.panelNepal.TabIndex = 0;
            // 
            // pictureBoxUAE
            // 
            this.pictureBoxUAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUAE.Image")));
            this.pictureBoxUAE.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUAE.Name = "pictureBoxUAE";
            this.pictureBoxUAE.Size = new System.Drawing.Size(389, 392);
            this.pictureBoxUAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUAE.TabIndex = 1;
            this.pictureBoxUAE.TabStop = false;
            // 
            // labelNepal
            // 
            this.labelNepal.AutoSize = true;
            this.labelNepal.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNepal.Location = new System.Drawing.Point(491, 9);
            this.labelNepal.Name = "labelNepal";
            this.labelNepal.Size = new System.Drawing.Size(105, 38);
            this.labelNepal.TabIndex = 3;
            this.labelNepal.Text = "Nepal";
            this.labelNepal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNepalQuote
            // 
            this.labelNepalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNepalQuote.Location = new System.Drawing.Point(395, 47);
            this.labelNepalQuote.Name = "labelNepalQuote";
            this.labelNepalQuote.Size = new System.Drawing.Size(285, 59);
            this.labelNepalQuote.TabIndex = 4;
            this.labelNepalQuote.Text = "#The Land of Unparagoned Wonders";
            // 
            // labelNepalDescription
            // 
            this.labelNepalDescription.Location = new System.Drawing.Point(400, 106);
            this.labelNepalDescription.Name = "labelNepalDescription";
            this.labelNepalDescription.Size = new System.Drawing.Size(280, 252);
            this.labelNepalDescription.TabIndex = 5;
            this.labelNepalDescription.Text = resources.GetString("labelNepalDescription.Text");
            // 
            // FormNepal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 392);
            this.Controls.Add(this.panelNepal);
            this.Name = "FormNepal";
            this.Text = "panel";
            this.panelNepal.ResumeLayout(false);
            this.panelNepal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUAE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNepal;
        private System.Windows.Forms.PictureBox pictureBoxUAE;
        private System.Windows.Forms.Label labelNepal;
        private System.Windows.Forms.Label labelNepalDescription;
        private System.Windows.Forms.Label labelNepalQuote;
    }
}