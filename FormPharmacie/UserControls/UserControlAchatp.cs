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
    public partial class UserControlAchatp : UserControl
    {
        public UserControlAchatp()
        {
            InitializeComponent();
        }

        private void BtnAccader1_Click(object sender, EventArgs e)
        {
              panelCenter1.Visible = false;
            UserControlAchat user = new UserControlAchat();
            AddControlTopanel(user);

        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            panelCenter1.Visible = false;
            UserControlHistoriqueAcht user = new UserControlHistoriqueAcht();
            AddControlTopanel(user);
        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {
            panelCenter1.Visible = false;
            UserControlCommande user = new UserControlCommande();
            AddControlTopanel(user);
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            panelCenter1.Visible = false;
            UserControlHistoriqueCommande user = new UserControlHistoriqueCommande();
            AddControlTopanel(user);
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
