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
    public partial class WhereWeFly : Form
    {
        public Form currentChildForm;

        public WhereWeFly()
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
            panelDestinations.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBhutan());
        }

        private void pictureBoxUAE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUAE());
        }

        private void pictureBoxSriLanka_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSriLanka());
        }

        private void pictureBoxNepal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNepal());
        }

        private void pictureBoxIndia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormIndia());
        }

        private void pictureBoxMaldives_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMaldives());
        }
    }
}
