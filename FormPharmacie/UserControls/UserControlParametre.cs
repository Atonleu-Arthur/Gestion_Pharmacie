using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie.UserControls
{
    public partial class UserControlParametre : UserControl
    {
        public UserControlParametre()
        {
            InitializeComponent();
        }

        private void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCentre.Controls.Clear();
            panelCentre.Controls.Add(c);
        }
     

        private void BtnAccader1_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            FormParentPharmacie f = new FormParentPharmacie();
            UserControlGestUtilisateur user = new UserControlGestUtilisateur();
            AddControlTopanel(user);
        }

        private void GunaElipsePanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPamRayon_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            FormParentPharmacie f = new FormParentPharmacie();
            UserControlPamRayon user = new UserControlPamRayon();
            AddControlTopanel(user);
        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            FormParentPharmacie f = new FormParentPharmacie();
            UserControlInfosPharmacie user = new UserControlInfosPharmacie();
            AddControlTopanel(user);
        }
    }
}
