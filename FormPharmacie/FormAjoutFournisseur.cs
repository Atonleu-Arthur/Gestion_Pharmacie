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
    public partial class FormAjoutFournisseur : Form
    {
        private Fournisseur Fournisseur { get; set; }
        private UserControl formOwner  { get; set; }
        public FormAjoutFournisseur(UserControl owner)
        {
            InitializeComponent();
            formOwner = owner;

        }
        public FormAjoutFournisseur(UserControl owner, Fournisseur fournisseur) : this(owner)
        {
            Fournisseur = fournisseur;
            if (Fournisseur != null)
            {
                TxtNom.Text = fournisseur.Nom_fournisseur;
                TxtAdresse.Text = fournisseur.Adresse;
                TxtTelephone.Text =Convert.ToDouble(fournisseur.Telephone).ToString();

            }

        }
        public void InitForm()
        {
            TxtNom.Text = null;
            TxtAdresse.Text = null;
            TxtTelephone.Text = null;

        }
        private void CheckForm()
        {
            if (TxtNom == null || TxtAdresse== null || TxtTelephone.Text==null)
            {
                MessageBox.Show("Attention", "Veillez Completer tous les champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {

                CheckForm();
                FournisseurBLO fournisseurs = new FournisseurBLO();

                Fournisseur oldf = new Fournisseur(TxtNom.Text, TxtAdresse.Text, double.Parse(TxtTelephone.Text));

                Fournisseur newf = new Fournisseur(TxtNom.Text, TxtAdresse.Text, double.Parse(TxtTelephone.Text));

                if (Fournisseur == null)
                {

                    fournisseurs.Add(oldf);
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitForm();
                    UserControls.UserControlFournisseur f = formOwner as UserControls.UserControlFournisseur;
                    f?.LoadDataM(x => true);

                }
                else
                {
                    newf = fournisseurs.Edit(oldf, newf);
                
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                CheckForm();
                FournisseurBLO fournisseurs = new FournisseurBLO();

                Fournisseur oldf = new Fournisseur(TxtNom.Text, TxtAdresse.Text, double.Parse(TxtTelephone.Text));

                Fournisseur newf = new Fournisseur(TxtNom.Text, TxtAdresse.Text, double.Parse(TxtTelephone.Text));

                if (Fournisseur == null)
                {

                    fournisseurs.Add(oldf);
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitForm();
                    UserControls.UserControlFournisseur f = formOwner as UserControls.UserControlFournisseur;
                    f?.LoadDataM(x => true);

                }
                else
                {
                    newf = fournisseurs.Edit(oldf, newf);

                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
