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
using System.Runtime.InteropServices;
namespace GUI_Project
{
    public partial class FormLogin : Form
    {

        public Form currentChildForm;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new  FormRegister());
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
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panelLoginDesktop.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
        }
    }
}
