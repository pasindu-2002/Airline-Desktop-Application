namespace GUI_Project
{
    partial class FormRegister
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
            this.panelRegisterTop = new System.Windows.Forms.Panel();
            this.iconButtonRBack = new FontAwesome.Sharp.IconButton();
            this.labelLoyalty = new System.Windows.Forms.Label();
            this.labelEmiratesRegister = new System.Windows.Forms.Label();
            this.panelRegisterElements = new System.Windows.Forms.Panel();
            this.ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRegister = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CheckBoxRegister = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TextBoxRPassportNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRPassportNum = new System.Windows.Forms.Label();
            this.TextBoxRPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRPassword = new System.Windows.Forms.Label();
            this.TextBoxREmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelREmail = new System.Windows.Forms.Label();
            this.TextBoxRLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxRFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRLastName = new System.Windows.Forms.Label();
            this.labelRFirstName = new System.Windows.Forms.Label();
            this.labelRTitle = new System.Windows.Forms.Label();
            this.ComboBoxRTitle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelRegisterTop.SuspendLayout();
            this.panelRegisterElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegisterTop
            // 
            this.panelRegisterTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelRegisterTop.Controls.Add(this.iconButtonRBack);
            this.panelRegisterTop.Controls.Add(this.labelLoyalty);
            this.panelRegisterTop.Controls.Add(this.labelEmiratesRegister);
            this.panelRegisterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegisterTop.Location = new System.Drawing.Point(0, 0);
            this.panelRegisterTop.Name = "panelRegisterTop";
            this.panelRegisterTop.Size = new System.Drawing.Size(708, 68);
            this.panelRegisterTop.TabIndex = 0;
            // 
            // iconButtonRBack
            // 
            this.iconButtonRBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonRBack.FlatAppearance.BorderSize = 0;
            this.iconButtonRBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButtonRBack.IconColor = System.Drawing.Color.White;
            this.iconButtonRBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRBack.IconSize = 32;
            this.iconButtonRBack.Location = new System.Drawing.Point(0, 0);
            this.iconButtonRBack.Name = "iconButtonRBack";
            this.iconButtonRBack.Size = new System.Drawing.Size(64, 68);
            this.iconButtonRBack.TabIndex = 3;
            this.iconButtonRBack.UseVisualStyleBackColor = true;
            // 
            // labelLoyalty
            // 
            this.labelLoyalty.AutoSize = true;
            this.labelLoyalty.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoyalty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLoyalty.Location = new System.Drawing.Point(273, 40);
            this.labelLoyalty.Name = "labelLoyalty";
            this.labelLoyalty.Size = new System.Drawing.Size(97, 19);
            this.labelLoyalty.TabIndex = 1;
            this.labelLoyalty.Text = "-LOYALTY-";
            // 
            // labelEmiratesRegister
            // 
            this.labelEmiratesRegister.AutoSize = true;
            this.labelEmiratesRegister.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmiratesRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmiratesRegister.Location = new System.Drawing.Point(208, 9);
            this.labelEmiratesRegister.Name = "labelEmiratesRegister";
            this.labelEmiratesRegister.Size = new System.Drawing.Size(307, 29);
            this.labelEmiratesRegister.TabIndex = 0;
            this.labelEmiratesRegister.Text = "JOIN EMIRATES SKYWARDS";
            // 
            // panelRegisterElements
            // 
            this.panelRegisterElements.BackColor = System.Drawing.Color.White;
            this.panelRegisterElements.Controls.Add(this.ButtonClear);
            this.panelRegisterElements.Controls.Add(this.ButtonRegister);
            this.panelRegisterElements.Controls.Add(this.linkLabel1);
            this.panelRegisterElements.Controls.Add(this.CheckBoxRegister);
            this.panelRegisterElements.Controls.Add(this.TextBoxRPassportNum);
            this.panelRegisterElements.Controls.Add(this.labelRPassportNum);
            this.panelRegisterElements.Controls.Add(this.TextBoxRPassword);
            this.panelRegisterElements.Controls.Add(this.labelRPassword);
            this.panelRegisterElements.Controls.Add(this.TextBoxREmail);
            this.panelRegisterElements.Controls.Add(this.labelREmail);
            this.panelRegisterElements.Controls.Add(this.TextBoxRLastName);
            this.panelRegisterElements.Controls.Add(this.TextBoxRFirstName);
            this.panelRegisterElements.Controls.Add(this.labelRLastName);
            this.panelRegisterElements.Controls.Add(this.labelRFirstName);
            this.panelRegisterElements.Controls.Add(this.labelRTitle);
            this.panelRegisterElements.Controls.Add(this.ComboBoxRTitle);
            this.panelRegisterElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegisterElements.Location = new System.Drawing.Point(0, 68);
            this.panelRegisterElements.Name = "panelRegisterElements";
            this.panelRegisterElements.Size = new System.Drawing.Size(708, 332);
            this.panelRegisterElements.TabIndex = 1;
            // 
            // ButtonClear
            // 
            this.ButtonClear.BorderRadius = 9;
            this.ButtonClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ButtonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ButtonClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(367, 281);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(155, 45);
            this.ButtonClear.TabIndex = 17;
            this.ButtonClear.Text = "Clear";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BorderRadius = 9;
            this.ButtonRegister.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ButtonRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ButtonRegister.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(154, 281);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(155, 45);
            this.ButtonRegister.TabIndex = 16;
            this.ButtonRegister.Text = "Register";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.linkLabel1.Location = new System.Drawing.Point(252, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(170, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Terms and Conditions";
            // 
            // CheckBoxRegister
            // 
            this.CheckBoxRegister.AutoSize = true;
            this.CheckBoxRegister.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxRegister.CheckedState.BorderRadius = 0;
            this.CheckBoxRegister.CheckedState.BorderThickness = 0;
            this.CheckBoxRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxRegister.Location = new System.Drawing.Point(213, 251);
            this.CheckBoxRegister.Name = "CheckBoxRegister";
            this.CheckBoxRegister.Size = new System.Drawing.Size(274, 20);
            this.CheckBoxRegister.TabIndex = 14;
            this.CheckBoxRegister.Text = "I agree to the above terms and conditions";
            this.CheckBoxRegister.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxRegister.UncheckedState.BorderRadius = 0;
            this.CheckBoxRegister.UncheckedState.BorderThickness = 0;
            this.CheckBoxRegister.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // TextBoxRPassportNum
            // 
            this.TextBoxRPassportNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRPassportNum.DefaultText = "";
            this.TextBoxRPassportNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRPassportNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRPassportNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRPassportNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRPassportNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRPassportNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRPassportNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.TextBoxRPassportNum.Location = new System.Drawing.Point(213, 180);
            this.TextBoxRPassportNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxRPassportNum.Name = "TextBoxRPassportNum";
            this.TextBoxRPassportNum.PasswordChar = '\0';
            this.TextBoxRPassportNum.PlaceholderText = "";
            this.TextBoxRPassportNum.SelectedText = "";
            this.TextBoxRPassportNum.Size = new System.Drawing.Size(209, 35);
            this.TextBoxRPassportNum.TabIndex = 13;
            // 
            // labelRPassportNum
            // 
            this.labelRPassportNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPassportNum.Location = new System.Drawing.Point(18, 180);
            this.labelRPassportNum.Name = "labelRPassportNum";
            this.labelRPassportNum.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelRPassportNum.Size = new System.Drawing.Size(188, 36);
            this.labelRPassportNum.TabIndex = 12;
            this.labelRPassportNum.Text = "Passport Number :";
            this.labelRPassportNum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TextBoxRPassword
            // 
            this.TextBoxRPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRPassword.DefaultText = "";
            this.TextBoxRPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.TextBoxRPassword.Location = new System.Drawing.Point(498, 126);
            this.TextBoxRPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxRPassword.Name = "TextBoxRPassword";
            this.TextBoxRPassword.PasswordChar = '\0';
            this.TextBoxRPassword.PlaceholderText = "";
            this.TextBoxRPassword.SelectedText = "";
            this.TextBoxRPassword.Size = new System.Drawing.Size(179, 35);
            this.TextBoxRPassword.TabIndex = 11;
            // 
            // labelRPassword
            // 
            this.labelRPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPassword.Location = new System.Drawing.Point(358, 125);
            this.labelRPassword.Name = "labelRPassword";
            this.labelRPassword.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelRPassword.Size = new System.Drawing.Size(125, 36);
            this.labelRPassword.TabIndex = 10;
            this.labelRPassword.Text = "Password :";
            this.labelRPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TextBoxREmail
            // 
            this.TextBoxREmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxREmail.DefaultText = "";
            this.TextBoxREmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxREmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxREmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxREmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxREmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxREmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxREmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.TextBoxREmail.Location = new System.Drawing.Point(154, 126);
            this.TextBoxREmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxREmail.Name = "TextBoxREmail";
            this.TextBoxREmail.PasswordChar = '\0';
            this.TextBoxREmail.PlaceholderText = "";
            this.TextBoxREmail.SelectedText = "";
            this.TextBoxREmail.Size = new System.Drawing.Size(179, 35);
            this.TextBoxREmail.TabIndex = 9;
            this.TextBoxREmail.TextChanged += new System.EventHandler(this.TextBoxREmail_TextChanged);
            // 
            // labelREmail
            // 
            this.labelREmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREmail.Location = new System.Drawing.Point(10, 125);
            this.labelREmail.Name = "labelREmail";
            this.labelREmail.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelREmail.Size = new System.Drawing.Size(96, 36);
            this.labelREmail.TabIndex = 8;
            this.labelREmail.Text = "Email:";
            this.labelREmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TextBoxRLastName
            // 
            this.TextBoxRLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRLastName.DefaultText = "";
            this.TextBoxRLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.TextBoxRLastName.Location = new System.Drawing.Point(498, 73);
            this.TextBoxRLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxRLastName.Name = "TextBoxRLastName";
            this.TextBoxRLastName.PasswordChar = '\0';
            this.TextBoxRLastName.PlaceholderText = "";
            this.TextBoxRLastName.SelectedText = "";
            this.TextBoxRLastName.Size = new System.Drawing.Size(179, 35);
            this.TextBoxRLastName.TabIndex = 7;
            // 
            // TextBoxRFirstName
            // 
            this.TextBoxRFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRFirstName.DefaultText = "";
            this.TextBoxRFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.TextBoxRFirstName.Location = new System.Drawing.Point(154, 73);
            this.TextBoxRFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxRFirstName.Name = "TextBoxRFirstName";
            this.TextBoxRFirstName.PasswordChar = '\0';
            this.TextBoxRFirstName.PlaceholderText = "";
            this.TextBoxRFirstName.SelectedText = "";
            this.TextBoxRFirstName.Size = new System.Drawing.Size(179, 35);
            this.TextBoxRFirstName.TabIndex = 6;
            this.TextBoxRFirstName.TextChanged += new System.EventHandler(this.TextBoxRFirstName_TextChanged);
            // 
            // labelRLastName
            // 
            this.labelRLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRLastName.Location = new System.Drawing.Point(362, 73);
            this.labelRLastName.Name = "labelRLastName";
            this.labelRLastName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelRLastName.Size = new System.Drawing.Size(125, 36);
            this.labelRLastName.TabIndex = 4;
            this.labelRLastName.Text = "Last Name :";
            this.labelRLastName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelRFirstName
            // 
            this.labelRFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRFirstName.Location = new System.Drawing.Point(18, 73);
            this.labelRFirstName.Name = "labelRFirstName";
            this.labelRFirstName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelRFirstName.Size = new System.Drawing.Size(130, 36);
            this.labelRFirstName.TabIndex = 3;
            this.labelRFirstName.Text = "First Name :";
            this.labelRFirstName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelRTitle
            // 
            this.labelRTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRTitle.Location = new System.Drawing.Point(18, 17);
            this.labelRTitle.Name = "labelRTitle";
            this.labelRTitle.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelRTitle.Size = new System.Drawing.Size(76, 36);
            this.labelRTitle.TabIndex = 2;
            this.labelRTitle.Text = "Title :";
            this.labelRTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ComboBoxRTitle
            // 
            this.ComboBoxRTitle.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxRTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRTitle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxRTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxRTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ComboBoxRTitle.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.ComboBoxRTitle.ItemHeight = 30;
            this.ComboBoxRTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs."});
            this.ComboBoxRTitle.Location = new System.Drawing.Point(154, 17);
            this.ComboBoxRTitle.Name = "ComboBoxRTitle";
            this.ComboBoxRTitle.Size = new System.Drawing.Size(179, 36);
            this.ComboBoxRTitle.TabIndex = 0;
            this.ComboBoxRTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRTitle_SelectedIndexChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 400);
            this.Controls.Add(this.panelRegisterElements);
            this.Controls.Add(this.panelRegisterTop);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panelRegisterTop.ResumeLayout(false);
            this.panelRegisterTop.PerformLayout();
            this.panelRegisterElements.ResumeLayout(false);
            this.panelRegisterElements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegisterTop;
        private System.Windows.Forms.Label labelEmiratesRegister;
        private System.Windows.Forms.Label labelLoyalty;
        private System.Windows.Forms.Panel panelRegisterElements;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxRTitle;
        private System.Windows.Forms.Label labelRTitle;
        private Guna.UI2.WinForms.Guna2Button ButtonClear;
        private Guna.UI2.WinForms.Guna2Button ButtonRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxRegister;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRPassportNum;
        private System.Windows.Forms.Label labelRPassportNum;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRPassword;
        private System.Windows.Forms.Label labelRPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxREmail;
        private System.Windows.Forms.Label labelREmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRLastName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRFirstName;
        private System.Windows.Forms.Label labelRLastName;
        private System.Windows.Forms.Label labelRFirstName;
        private FontAwesome.Sharp.IconButton iconButtonRBack;
    }
}