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
    public partial class UserControlHistoriqueAcht : UserControl
    {

        public UserControlHistoriqueAcht()
        {
            InitializeComponent();
        }

        private void BtnNAchat_Click(object sender, EventArgs e)
        {

        }
        public void LoadDataHistA (Func<HistoriqueAchat, bool> predicat)
        {
            double prix_total=0;
            HistoriqueAchatBLO historique = new HistoriqueAchatBLO();
            IEnumerable<HistoriqueAchat> historiques = historique.Find(predicat);
            gunaDataGridView1.AutoGenerateColumns = false;
            gunaDataGridView1.DataSource = historiques;
            foreach(HistoriqueAchat ha in historiques)
            {
                prix_total = prix_total + ha.Prix_total;
            }
            lblTotalHT.Text = prix_total.ToString();
            lblTotaTTC.Text = lblTotalHT.Text;
            labeltotalR.Text = lblTotaTTC.Text;
        }


                      
        private void BtnNvAchat_Click(object sender, EventArgs e)
        {

            FormDashboardPharmacie f = new FormDashboardPharmacie();
            UserControlAchat user = new UserControlAchat();
            f.AddControlTopanel(user);

        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlHistoriqueAcht_Load(object sender, EventArgs e)
        {
            LoadDataHistA(x => true);
            LoadDataF(x => true);
        }

        private void ComboBoxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoadDataHistA(x =>

           //x.Fournisseur.ToString().Contains(ComboBoxFournisseur.SelectedItem?.ToString() ?? ""));
          
        }
        public void LoadDataF(Func<Fournisseur, bool> predicat)
        {

            FournisseurBLO fournisseurs = new FournisseurBLO();
            IEnumerable<Fournisseur> us = fournisseurs.Find(predicat);

            if (us != null)
            {
                
                ComboBoxFournisseur.DataSource = us;
                comboBox.DataSource = us;           
            
            }
        }
        public void RefreshGrid()
        {
            gunaDataGridView1.DataSource = null;
            LoadDataHistA(x => true);
        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            HistoriqueAchatBLO historique = new HistoriqueAchatBLO();
            if (gunaDataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer cet achat?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HistoriqueAchat hachat = null;
                    for (int i = 0; i < gunaDataGridView1.SelectedRows.Count; i++)
                    {
                        hachat = gunaDataGridView1.SelectedRows[i].DataBoundItem as HistoriqueAchat;
                        historique.Remove(hachat);

                    }
                    RefreshGrid();
                }
            }
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

        private void BtnNewachat_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlAchat user = new UserControlAchat();
            AddControlTopanel(user);
        }
    }
}
