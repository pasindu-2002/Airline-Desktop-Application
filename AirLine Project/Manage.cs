using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class Manage : Form
    {
        public Form currentChildForm;
        public Manage()
        {
            InitializeComponent();
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
            panelManage.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUpdateTicket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpdateTicket());
        }

        private void ButtonUpdateSkywards_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpdateSkywards());
        }
    }
}
