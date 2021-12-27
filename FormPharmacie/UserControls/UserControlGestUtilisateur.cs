using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPharmacie.UserControls;
using ProjetPharmacie;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.Multicouche.BLL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlGestUtilisateur : UserControl
    {
        public Produit Produit { get; set; }
        public UserControlGestUtilisateur()
        {
            InitializeComponent();
            List<string> roles = new List<string>(Enum.GetNames(typeof(Utilisateur.RoleOption)));
            //string[] roles = Enum.GetNames(typeof(Utilisateur.RoleOption));
            roles.Insert(0, "All");
            ComboRole.DataSource = roles;
            ComboRole.SelectedIndex = 0;
            ComboRole.Refresh();
            //TxtRechercher.TextChanged += TxtRechercher_TextChanged; //genere en appuyant sur tabulation en ayant choisi l'evenement click
            //ComboRole.SelectedIndexChanged += ComboRole_SelectedIndexChanged;
        }

        private void UserControlGestUtilisateur_Load(object sender, EventArgs e)
        {
            LoadData(x => true);
        }



        public void LoadData(Func<Utilisateur, bool> predicat)
        {
         
            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            IEnumerable<Utilisateur> us = utilisateurs.Find(predicat);
            listView1.Items.Clear();
            if (us != null)
            {
                foreach (Utilisateur u in us)
                {
                    string[] t = { u.Compte, u.Nom_Complet, u.Role.ToString(), u.LasConnexionDate.ToString(), u.Telephone };
                    ListViewItem lvi = new ListViewItem(t);
                    lvi.Tag = u;
                    listView1.Items.Add(lvi);
                    listView1.Refresh();
                }
            }
        }


    


       


        private void BtnModifierUtilisateur_Click_1(object sender, EventArgs e)
        {
            

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
      
     

        private void BtnRechercher_Click_1(object sender, EventArgs e)
        {
        }

        private void TxtRechercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnModifierUtilisateur_Click_1(sender, e);

        }

        private void BtnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                FormAjoutUtilisateur f = new FormAjoutUtilisateur(this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            //try
            //{

                if (listView1.SelectedItems.Count > 0)
                {
                    //charge(listView1.SelectedItems[0].Tag as Produit);

                    FormAjoutUtilisateur f = new FormAjoutUtilisateur(this,
                    listView1.SelectedItems[0].Tag as Utilisateur);

                    f.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Vous devez selectionner un élément dans la liste!", "Attention!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void BtnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Voulez vouz vraiment supprimer cette utilisateur?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UtilisateurBLO utilisateurs = new UtilisateurBLO();
                        foreach (ListViewItem lvi in listView1.SelectedItems)
                        {
                            Utilisateur u = (Utilisateur)listView1.SelectedItems[0].Tag;
                            utilisateurs.Remove(u);
                        }
                        BtnRechercher_Click(sender, e);
                        MessageBox.Show("Supprimer avec sucess!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vous devez selectionner un element dans la liste", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {

            LoadData(x =>
          (x.Compte.ToLower().Contains(TxtRechercher.Text) ||
          x.Nom_Complet.ToLower().Contains(TxtRechercher.Text)) &&
          x.Role.ToString().Contains(ComboRole.SelectedItem?.ToString() ?? "")
          );
        }

        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRechercher_Click(sender, e);

        }

        private void BtnActualiser_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRechercher.Text))
                TxtRechercher.Text = null;
            else
                LoadData(x => true);
        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlParametre user = new UserControlParametre();
            AddControlTopanel(user);
        }
    }
}
