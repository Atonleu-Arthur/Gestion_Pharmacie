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

namespace FormPharmacie.UserControls
{
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {
            LoadData(x => true);
        }
        public void LoadData(Func<Client, bool> predicat)
        {

            ClientBLO clients = new ClientBLO();
            IEnumerable<Client> us = clients.Find(predicat);
            listView1.Items.Clear();
            if (us != null)
            {
                foreach (Client u in us)
                {
                    string[] t = { u.Id_Client.ToString(),u.Nom_Complet };
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
                    if (MessageBox.Show("Voulez vouz vraiment supprimer ce client?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClientBLO clients = new ClientBLO();
                        foreach (ListViewItem lvi in listView1.SelectedItems)
                        {
                            Client u = (Client)listView1.SelectedItems[0].Tag;
                            clients.Remove(u);
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

        private void BtnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.SelectedItems.Count > 0)
                {

                    FormAjoutClient f = new FormAjoutClient(this,
                    listView1.SelectedItems[0].Tag as Client);

                    f.ShowDialog();


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

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            LoadData(x =>
          (x.Nom_Complet.ToLower().Contains(TxtRechercher.Text))
          );
          
        }

        public void BtnActualiser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRechercher.Text))
                TxtRechercher.Text = null;
            else
                LoadData(x => true);
        }
    }
}
