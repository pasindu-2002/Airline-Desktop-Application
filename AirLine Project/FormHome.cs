using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices; //Library used for dragging the form
namespace GUI_Project
{
    public partial class FormHome : Form
    {
        //Fields
        public IconButton currentbtn;
        public Panel leftBorderBtn;
        public Form currentChildForm;

        //Constructor
        public FormHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Removing control bar
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }

        public struct RGBColors
        {
            public static Color color1 =Color.FromArgb(215,25,33);
        }

        //Methods
        public void Activatebutton(object senderBtn,Color color) 
        {
            if (senderBtn != null) 
            {
                DisableButton();
                //Buttton
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(5,5,5);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon child form
                iconCurrentChildForm.IconChar=currentbtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Gainsboro;
            }
        }

        public void DisableButton()
        {
            if(currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(51, 51, 51);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form Childform)
        {
            if (currentChildForm != null)
            {
                //Open only one form
                currentChildForm.Close();
            }
            currentChildForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle=FormBorderStyle.None;
            Childform.Dock=DockStyle.Fill;
            panelDesktop.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
            labelChildForm.Text = Childform.Text;

        }

        public void iconButtonBook_Click(object sender, EventArgs e)
        {
            Activatebutton(sender,RGBColors.color1);
            OpenChildForm(new Book());
        }

        public void iconButtonManage_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new Manage());
        }

        public void iconButtonExperience_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new Experience());
        }

        public void iconButtonWhereWeFly_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new WhereWeFly());
        }

        public void iconButtonLoyalty_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new Loyalty());
        }

        public void iconButtonHelp_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new Help());
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible= false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            labelChildForm.Text = "Home";
        }


        //Code to drag the windows form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lParam);

        public void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void iconButtonLogIn_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, RGBColors.color1);
            OpenChildForm(new FormLogin());
        }
    }
}
