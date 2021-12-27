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
using static System.Windows.Forms.ListViewItem;

namespace FormPharmacie.UserControls
{
    public partial class UserMedicament : UserControl
    {
        public UserMedicament()
        {
            InitializeComponent();
        }

        private void UserMedicament_Load(object sender, EventArgs e)
        {
            LoadDataM(x => true);

        }

        private void BtnAjoutNomMed_Click(object sender, EventArgs e)
        {
            FormAjoutMedicament formAjoutMedicament = new FormAjoutMedicament(this);
            formAjoutMedicament.ShowDialog();
        }
        public void LoadDataM(Func<Medicament, bool> predicat)
        {

            MedicamentBLL medicaments = new MedicamentBLL();
            IEnumerable<Medicament> us = medicaments.Find(predicat);
            listView1.Items.Clear();
            if (us != null)
            {
                foreach (Medicament u in us)
                {
                    string[] t = { u.Id_Medicament.ToString(), u.Nom_medicament, u.Remarque};
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
                        MedicamentBLL medicaments = new MedicamentBLL();
                        foreach (ListViewItem lvi in listView1.SelectedItems)
                        {
                            Medicament u = (Medicament)listView1.SelectedItems[0].Tag;
                            medicaments.Remove(u);
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
           (x.Nom_medicament.ToLower().Contains(TxtRechercher.Text))
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

                    FormAjoutMedicament f = new FormAjoutMedicament(this,
                    listView1.SelectedItems[0].Tag as Medicament);

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
