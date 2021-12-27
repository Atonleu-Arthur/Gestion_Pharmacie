using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie.Multicouche.BLL;
using ProjetPharmacie;

namespace FormPharmacie.UserControls
{
    public partial class UserControlInfosPharmacie : UserControl
    {
        public Pharmacie Pharmacie  { get; set; }
        PharmacieBLO pharmacie = new PharmacieBLO();
        Pharmacie pharmacie1;

        public UserControlInfosPharmacie()
        {
            InitializeComponent();
        }
        public void  charge(Pharmacie pharmacie)
        {
            Pharmacie = pharmacie;
            if(Pharmacie!=null)
            {

            }

        }
        private void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
        }

     

     

        private void BtnModifier1_Click_1(object sender, EventArgs e)
        {
            txtAdresse.Enabled = true;
            txtContact.Enabled = true;
            TxtGerant.Enabled = true;
            txtNomPharmacie.Enabled = true;
            Pharmacie newpharmacie1 = new Pharmacie
              (
              txtNomPharmacie.Text, txtAdresse.Text, TxtGerant.Text, gunaPictureBox1.ImageLocation, double.Parse(txtContact.Text)
              );
           newpharmacie1= pharmacie.Edit(pharmacie1, newpharmacie1);
            MessageBox.Show("Modification réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAdresse.Enabled = false;
            txtContact.Enabled = false;
            TxtGerant.Enabled = false;
            txtNomPharmacie.Enabled = false;
        }

        private void GunaButton1_Click_1(object sender, EventArgs e)
        {
            pharmacie1 = new Pharmacie
               (
               txtNomPharmacie.Text, txtAdresse.Text, TxtGerant.Text, gunaPictureBox1.ImageLocation, double.Parse(txtContact.Text)
               );

            if (Pharmacie == null)
            {
                pharmacie.Add(pharmacie1);
                MessageBox.Show("Enregistrement réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdresse.Enabled = false;
                txtContact.Enabled = false;
                TxtGerant.Enabled = false;
                txtNomPharmacie.Enabled = false;
                gunaButton1.Enabled = false;
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlParametre user = new UserControlParametre();
            AddControlTopanel(user);
        }
    }
}
