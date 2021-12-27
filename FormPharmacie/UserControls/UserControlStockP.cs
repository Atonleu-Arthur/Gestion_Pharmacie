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
    public partial class UserControlStockP : UserControl
    {
        public UserControlStockP()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }
        private void BtnSGStock_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlStockSG user = new UserControlStockSG();
            AddControlTopanel(user);

        }

        private void BtnSDSTOCK_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlStockSD user = new UserControlStockSD();
            AddControlTopanel(user);
        }

        private void BtnInventaire_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlInventaire user = new UserControlInventaire();
            AddControlTopanel(user);
        }
    }
}
