using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie
{
    public partial class FormChoixClient : Form
    {
        bool closeApp = true;
        public Client Client { get; set; }
        private string nomcli;
        public string Nomcli
        {
            get { return nomcli; }
            set { nomcli = value; }
        }

        public FormChoixClient()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string[] t = { u.Nom_Complet };
                    ListViewItem lvi = new ListViewItem(t);
                    lvi.Tag = u;
                    listView1.Items.Add(lvi);
                    listView1.Refresh();
                }
            }
        }
        private void FormChoixClient_Load(object sender, EventArgs e)
        {
            LoadData(x => true);
        }
        public void Actualiser()
        {
            if (!string.IsNullOrEmpty(TxtRechercher.Text))
                TxtRechercher.Text = null;
            else
                LoadData(x => true);
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.SelectedItems.Count > 0)
                {



                    this.Close();


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

        public void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BtnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            FormAjoutClient f = new FormAjoutClient();
            f.ShowDialog();
            Close();

        }

        private void FormChoixClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApp)
                this.Close();
        }

        private void BtnValideCli_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Client = listView1.SelectedItems[0].Tag as Client;

                if (Client != null)
                {

                    Nomcli = (listView1.SelectedItems[0].Tag as Client).Nom_Complet;
                }

                this.Close();
            }
        }
    }
}
