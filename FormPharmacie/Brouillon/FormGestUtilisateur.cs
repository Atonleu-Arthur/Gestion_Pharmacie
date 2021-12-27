using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;


namespace FormPharmacie
{
    public partial class FormGestUtilisateur : Form
    {
        public FormGestUtilisateur()
        {

            InitializeComponent();
            List<string> roles = new List<string>(Enum.GetNames(typeof(Utilisateur.RoleOption)));
            //string[] roles = Enum.GetNames(typeof(Utilisateur.RoleOption));
            roles.Insert(0, "All");
            ComboRole.DataSource = roles; 
            ComboRole.SelectedIndex = 0;
            ComboRole.Refresh();
            TxtRechercher.TextChanged += TxtRechercher_TextChanged; //genere en appuyant sur tabulation en ayant choisi l'evenement click
            ComboRole.SelectedIndexChanged += ComboRole_SelectedIndexChanged;
        }
        
        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rechercher_Click(sender, e);// Permet la recher automatique sans âppuiyer sur le bouton
        }

        private void TxtRechercher_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormGestUtilisateur_Load(object sender, EventArgs e)
        {
            LoadData(x => true);
        }

        private void FormGestUtilisateur_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            FormParametrePharmacie f = new FormParametrePharmacie();
            f.IsMdiContainer = false;
            f.visible();
            

        }

        private void FormGestUtilisateur_FormClosing(object sender, FormClosingEventArgs e)
        {

           

        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                //FormAjoutUtilisateur f = new FormAjoutUtilisateur(this);
                //f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void BtnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.SelectedItems.Count > 0)
                {

                    //FormAjoutUtilisateur f = new FormAjoutUtilisateur(this, 
                    //listView1.SelectedItems[0].Tag as Utilisateur);

                    //f.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Vous devez selectionner un élément dans la liste!", "Attention!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
          
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void LoadData(Func<Utilisateur, bool > predicat)
        {
           
            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            IEnumerable<Utilisateur> us = utilisateurs.Find(predicat);
            listView1.Items.Clear();
            if(us != null)
            {
                foreach( Utilisateur u in us)
                {
                    string[] t = { u.Compte, u.Nom_Complet, u.Role.ToString() ,u.Telephone,u.LasConnexionDate.ToString()};
                    ListViewItem lvi = new ListViewItem(t);
                    lvi.Tag = u;
                    listView1.Items.Add(lvi);
                    listView1.Refresh();
                }
            }
        }

        private void BtnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {

            try
            {
                if(listView1.SelectedItems.Count>0)
                {
                    if (MessageBox.Show("Voulez vouz vraiment supprimer cette utilisateur?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
                    {
                        UtilisateurBLO utilisateurs = new UtilisateurBLO();
                        foreach (ListViewItem lvi in listView1.SelectedItems)
                        {
                            Utilisateur u =(Utilisateur)listView1.SelectedItems[0].Tag;
                            utilisateurs.Remove(u);
                        }
                        Rechercher_Click(sender, e);
                        MessageBox.Show("Supprimer avec sucess!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vous devez selectionner un element dans la liste", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            BtnModifierUtilisateur_Click(sender , e);
        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRechercher.Text))
                TxtRechercher.Text = null;
            else
                LoadData(x => true);
        }
             
        private void Rechercher_Click(object sender, EventArgs e)
        {
            LoadData(x =>
            (x.Compte.ToLower().Contains(TxtRechercher.Text) ||
            x.Nom_Complet.ToLower().Contains(TxtRechercher.Text)) &&
            x.Role.ToString().Contains(ComboRole.SelectedItem?.ToString()?? "")
            );
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
