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
    public partial class FormAjoutClient : Form
    {
        private Client Client { get; set; }
        private UserControl formOwner { get; set; }
        public FormAjoutClient()
        {
          InitializeComponent();

        }
        public FormAjoutClient(UserControl owner)
        {
            InitializeComponent();
            formOwner = owner;

        }
        public FormAjoutClient(UserControl owner, Client client) : this(owner)
        {
            Client = client;
            if (Client != null)
            {
                TxtNomClient.Text = client.Nom_Complet;

            }

        }

        public void InitForm()
        {
            TxtNomClient.Text = null;

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void CheckForm()
        {
            if (TxtNomClient == null)
            {
                MessageBox.Show("Attention", "Entrer un nom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {

                CheckForm();

                ClientBLO clients = new ClientBLO();

                Client newclient = new Client( TxtNomClient.Text);
              
                Client oldclient = new Client( TxtNomClient.Text);
                if (Client == null)
                {

                    clients.Add(oldclient);
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitForm();
                    UserControls.UserControlClient f = formOwner as UserControls.UserControlClient;
                    f?.LoadData(x => true);
                    this.Close();
                    

                }
                else
                {
                    newclient = clients.Edit(oldclient, newclient);
                   
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserControls.UserControlClient f = formOwner as UserControls.UserControlClient;
                    f.BtnActualiser_Click(sender,e);
                    FormChoixClient form = new FormChoixClient();
                    form.ShowDialog();

                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
