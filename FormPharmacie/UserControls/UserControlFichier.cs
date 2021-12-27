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
    public partial class UserControlFichier : UserControl
    {
        public UserControlFichier()
        {
            InitializeComponent();
        }

        private void GunaGradientPanel3_Click(object sender, EventArgs e)
        {

        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }

        private void BtnAccader1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAccader1_Click_1(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlMedicament user = new UserControlMedicament();
            AddControlTopanel(user);

        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void GunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
