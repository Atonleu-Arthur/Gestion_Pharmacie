using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPharmacie.UserControls;

namespace FormPharmacie
{
    public partial class FormParametre : Form
    {
        public FormParametre()
        {
            InitializeComponent();
        }

        private void GunaButton36_Click(object sender, EventArgs e)
        {
            FormParentPharmacie f = new FormParentPharmacie();
            this.Dispose();
            f.ShowDialog();
        }

        private void GunaButton9_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }
        private void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            //panelCentre2P.Controls.Clear();
            panelCentre2P.Controls.Add(c);
        }
        private void GunaButton4_Click(object sender, EventArgs e)
        {
            LabelQualification.Visible = true;
            btnRetour.Visible = true;
            panelCentreParametre.Visible=false;
            UserControlGestUtilisateur user = new UserControlGestUtilisateur();
            AddControlTopanel(user);

            
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            panelCentreParametre.Visible = true;
            panelCentreParametre.BringToFront();
            //panelCentre2P.Controls.Clear();
            btnRetour.Visible = false;
        }
    }
}
