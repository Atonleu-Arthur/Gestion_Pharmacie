using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.BO;

namespace FormPharmacie.UserControls
{
    public partial class UserControlFournisseur : UserControl
    {
        public UserControlFournisseur()
        {
            InitializeComponent();
        }

        private void UserControlFournisseur_Load(object sender, EventArgs e)
        {
            LoadDataM(x => true);
        }

        private void BtnAjoutNomF_Click(object sender, EventArgs e)
        {

            FormAjoutFournisseur formAjoutMedicament = new FormAjoutFournisseur(this);
            formAjoutMedicament.ShowDialog();
        }
        public void LoadDataM(Func<Fournisseur, bool> predicat)
        {

            FournisseurBLO fournisseurs = new FournisseurBLO();
            IEnumerable<Fournisseur> us = fournisseurs.Find(predicat);
            listView1.Items.Clear();
            if (us != null)
            {
                foreach (Fournisseur u in us)
                {
                    string[] t = { u.Nom_fournisseur,u.Adresse,u.Telephone.ToString() };
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
                if (listView1.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Voulez vouz vraiment supprimer cette utilisateur?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FournisseurBLO fournisseurs = new FournisseurBLO();
                        foreach (ListViewItem lvi in listView1.SelectedItems)
                        {
                            Fournisseur u = (Fournisseur)listView1.SelectedItems[0].Tag;
                            fournisseurs.Remove(u);
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
            LoadDataM(x =>
          (x.Nom_fournisseur.ToLower().Contains(TxtRechercher.Text))
          );

        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtRechercher.Text))
                TxtRechercher.Text = null;
            else
                LoadDataM(x => true);
        }

        private void BtnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.SelectedItems.Count > 0)
                {

                    FormAjoutFournisseur f = new FormAjoutFournisseur(this,
                    listView1.SelectedItems[0].Tag as Fournisseur);

                    f.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Vous devez selectionner un élément dans la liste!", "Attention!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnModifierUtilisateur_Click(sender, e);

        }
    }
}
