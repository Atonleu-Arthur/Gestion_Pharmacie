using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.Multicouche.BLL;
using ProjetPharmacie;

namespace FormPharmacie.UserControls
{
    public partial class UserControlCommande : UserControl
    {
        public List<Commande> listecommandes = new List<Commande>();
        public Commande Commande  { get; set; }
        public int Total_Quantite { get; set; }

        public UserControlCommande()
        {
            InitializeComponent();
            LoadDataM(x => true);
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
            ComboBoxFournisseur.SelectedIndex = -1;
            comboBox.SelectedIndex = -1;
        }

        public void InitForm()
        {
            TxtProduit.Text = null;
            txtQuantite.Text = null;
         

        }

       
        public void RefreshGrid()
        {
            DataGridView1.DataSource = null;
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = listecommandes;
            lblCompteurProduit.Text = DataGridView1.RowCount.ToString();

        }
        public double TotalProduit(List<Commande> commandes)
        {
            double total = 0;
            foreach(Commande c in commandes)
            {
                total = total + c.Quantite_commande ;
            }
            return total;
        }
        public Utilisateur LoadDatatrahison(Func<Utilisateur,bool> predicat)
        {
        
            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            FormDashboardPharmacie f = new FormDashboardPharmacie();
            IEnumerable<Utilisateur> liste = utilisateurs.Find(predicat);
            if(liste!=null)
            {
                foreach(Utilisateur u in liste)
                {
                    if(u.Nom_Complet ==f.txtNom.Text )
                    {
                        return  new Utilisateur(u.Nom_Complet);
                    }
                }
            }
            return null;
        }
        private void Btnvalider_Click(object sender, EventArgs e)
        {
            try
            {
                CommandeBLO commande = new CommandeBLO();
                Commande oldcommande = new Commande
                    (
                    txtObservation.Text, LoadDatatrahison(x => true), (Fournisseur)comboBox.SelectedItem, new Medicament(TxtProduit.Text), double.Parse(txtQuantite.Text), DateTime.Now
                    );
                if (Commande == null)
                {
                    listecommandes.Add(oldcommande);
                    RefreshGrid();
                    InitForm();
                    MessageBox.Show("Ajout réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
         
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            CommandeBLO commandes = new CommandeBLO();
            HistoriqueCommandeBLO historique1 = new HistoriqueCommandeBLO();
            HistoriqueCommande historique = new HistoriqueCommande
                (
                    txtObservation.Text, LoadDatatrahison(x => true), (Fournisseur)comboBox.SelectedItem,DateTime.Now, TotalProduit(listecommandes)
                );
            foreach (Commande c in listecommandes)
            {
                commandes.Add(c);
                
            }
            historique1.Add(historique);
            DataGridView1.DataSource = null;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce produit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Commande commande = null;
                    for (int i = 0; i < DataGridView1.SelectedRows.Count; i++)
                    {
                        commande = DataGridView1.SelectedRows[i].DataBoundItem as Commande;
                        listecommandes.Remove(commande);

                    }
                    RefreshGrid();
                }
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            listecommandes.Clear();
            RefreshGrid();
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnChoixP_Click_1(object sender, EventArgs e)
        {
            FormChoixProduit f = new FormChoixProduit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                TxtProduit.Text = f.Nomproduit;
            }
        }
    }
}
