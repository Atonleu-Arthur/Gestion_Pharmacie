using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie
{
    public partial class FormParametrePharmacie : Form
    {
        public FormParametrePharmacie()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void visible()
        {
            lblTitre.Visible = true;
            BtnMouchard.Visible = true;
            BtnGestUtilisateur.Visible = true;
            BtnStats.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;

        }
        public void Cacher()
        {
            lblTitre.Visible = false;
            BtnMouchard.Visible = false;
            BtnGestUtilisateur.Visible = false;
            BtnStats.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;







        }

        private void BtnGestUtilisateur_Click(object sender, EventArgs e)
        {
            FormGestUtilisateur formGestUtilisateur = new FormGestUtilisateur();
            IsMdiContainer = true;
            formGestUtilisateur.MdiParent = this;
            Cacher();
            formGestUtilisateur.Show();
        }
    }
}
