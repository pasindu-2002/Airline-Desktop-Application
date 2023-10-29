namespace GUI_Project
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.panelSideBook = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonBBook = new Guna.UI2.WinForms.Guna2Button();
            this.labelBookTitle2 = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelOffer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBook
            // 
            this.panelSideBook.BackColor = System.Drawing.Color.White;
            this.panelSideBook.Controls.Add(this.label1);
            this.panelSideBook.Controls.Add(this.labelOffer);
            this.panelSideBook.Controls.Add(this.pictureBox1);
            this.panelSideBook.Controls.Add(this.ButtonBBook);
            this.panelSideBook.Controls.Add(this.labelBookTitle2);
            this.panelSideBook.Controls.Add(this.labelBookTitle);
            this.panelSideBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideBook.Location = new System.Drawing.Point(0, 0);
            this.panelSideBook.Name = "panelSideBook";
            this.panelSideBook.Size = new System.Drawing.Size(708, 400);
            this.panelSideBook.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonBBook
            // 
            this.ButtonBBook.BorderRadius = 9;
            this.ButtonBBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonBBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBBook.ForeColor = System.Drawing.Color.White;
            this.ButtonBBook.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ButtonBBook.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonBBook.Location = new System.Drawing.Point(12, 231);
            this.ButtonBBook.Name = "ButtonBBook";
            this.ButtonBBook.Size = new System.Drawing.Size(106, 40);
            this.ButtonBBook.TabIndex = 2;
            this.ButtonBBook.Text = "Book";
            this.ButtonBBook.Click += new System.EventHandler(this.ButtonBBook_Click);
            // 
            // labelBookTitle2
            // 
            this.labelBookTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelBookTitle2.Location = new System.Drawing.Point(18, 167);
            this.labelBookTitle2.Name = "labelBookTitle2";
            this.labelBookTitle2.Size = new System.Drawing.Size(110, 70);
            this.labelBookTitle2.TabIndex = 1;
            this.labelBookTitle2.Text = "Click below now if you are!";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelBookTitle.Location = new System.Drawing.Point(12, 18);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(116, 144);
            this.labelBookTitle.TabIndex = 0;
            this.labelBookTitle.Text = "Ready to Fly with Us?";
            // 
            // labelOffer
            // 
            this.labelOffer.AutoSize = true;
            this.labelOffer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffer.Location = new System.Drawing.Point(27, 283);
            this.labelOffer.Name = "labelOffer";
            this.labelOffer.Size = new System.Drawing.Size(77, 27);
            this.labelOffer.TabIndex = 5;
            this.labelOffer.Text = "OFFER";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "100 $ for every South-Asian flight you book!";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 400);
            this.Controls.Add(this.panelSideBook);
            this.Name = "Book";
            this.Text = "Book";
            this.panelSideBook.ResumeLayout(false);
            this.panelSideBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBook;
        private System.Windows.Forms.Label labelBookTitle2;
        private System.Windows.Forms.Label labelBookTitle;
        private Guna.UI2.WinForms.Guna2Button ButtonBBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOffer;
    }
}