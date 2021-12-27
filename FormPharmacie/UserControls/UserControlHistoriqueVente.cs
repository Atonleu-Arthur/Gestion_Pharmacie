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
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.BO;

namespace FormPharmacie
{
    public partial class UserControlHistoriqueVente : UserControl
    {
        public UserControlHistoriqueVente()
        {
            InitializeComponent();
            LoadDataHistV(x => true);
            LoaDataC(x => true);
            LoaData(x => true);
        }
        public void LoadDataHistV(Func<HistoriqueVente,bool> predicat)
        {
            double benefice = 0;
            double versement = 0;
            HistoriqueVenteBLO historique = new HistoriqueVenteBLO();
            IEnumerable<HistoriqueVente> historiques = historique.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = historiques;
            foreach(HistoriqueVente v in historiques)
            {
                benefice = benefice + v.Total_Benefice;
                versement = versement + v.Versement;
            }

            lblBenefice.Text = benefice.ToString();
            lblversement.Text = versement.ToString();
            lblNbreProduit.Text = DataGridView1.RowCount.ToString();
        }
        public void LoaData(Func<Utilisateur, bool> predicat)
        {
            List<string> vs = new List<string>();

            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            IEnumerable<Utilisateur> us = utilisateurs.Find(predicat);
            if (us != null)
            {
                foreach (Utilisateur u in us)
                {
                    vs.Add(u.Nom_Complet);

                }
            }

            ComboUtilisateur.DataSource = vs;
            ComboUtilisateur.SelectedIndex = -1;
        }
        public void LoaDataC(Func<Client, bool> predicat)
        {
            List<string> vs = new List<string>();

            ClientBLO utilisateurs = new ClientBLO();
            IEnumerable<Client> us = utilisateurs.Find(predicat);
            if (us != null)
            {
                foreach (Client u in us)
                {
                    vs.Add(u.Nom_Complet);

                }
            }

            ComboClient.DataSource = vs;
            comboBox1.DataSource = vs;
            ComboClient.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void ComboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            rechercher();
      
        }

        private void ComboUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher();

        }
        private void rechercher()
        {
            LoaDataC(x =>
               x.Nom_Complet.ToString().Contains(ComboClient.SelectedItem?.ToString() ?? "")
                );
            LoaData(x =>
                      x.Nom_Complet.ToString().Contains(ComboUtilisateur.SelectedItem?.ToString() ?? "")

     );
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaDataC(x =>
               x.Nom_Complet.ToString().Contains(ComboClient.SelectedItem?.ToString() ?? "")
                );
        }
    }
}
