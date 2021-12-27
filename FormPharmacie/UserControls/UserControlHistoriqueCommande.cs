using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlHistoriqueCommande : UserControl
    {
        public UserControlHistoriqueCommande()
        {
            InitializeComponent();
            LoadDataM(x => true);
        }
        public void LoadData(Func<HistoriqueCommande,bool> predicat)
        {
            HistoriqueCommandeBLO historique = new HistoriqueCommandeBLO();
            IEnumerable<HistoriqueCommande> historiques = historique.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = historiques;
        }
        public void LoadDataM(Func<Fournisseur, bool> predicat)
        {

            FournisseurBLO fournisseurs = new FournisseurBLO();
            IEnumerable<Fournisseur> us = fournisseurs.Find(predicat);

            if (us != null)
            {
                List<Fournisseur> liste = new List<Fournisseur>(us);

                ComboBoxFournisseur.DataSource = liste;
                comboBox.DataSource = liste;



            }
        }

        private void UserControlHistoriqueCommande_Load(object sender, EventArgs e)
        {
            LoadData(x => true);
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlAchatp user = new UserControlAchatp();
            AddControlTopanel(user);
        }
      
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }

        private void BtnNewCommande_Click(object sender, EventArgs e)
        {

            panelCentre1.Visible = false;
            UserControlCommande user = new UserControlCommande();
            AddControlTopanel(user);
        }
    }
}
