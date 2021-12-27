using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.DAL;

namespace FormPharmacie
{
    public partial class FormAjoutUtilisateur : Form
    {

        private Utilisateur Utilisateur { get; set; }
        //private Form formOwner { get; set; }
         
        private UserControl formOwner { get; set; }

        public FormAjoutUtilisateur(UserControl owner)
        {

            InitializeComponent();
            string[] roles = Enum.GetNames(typeof(Utilisateur.RoleOption));
            ComboRole.DataSource = roles;
            ComboRole.SelectedIndex = 0;
            ComboRole.Refresh();
            formOwner = owner;
        }

        public FormAjoutUtilisateur( UserControl owner,Utilisateur utilisateur): this(owner)
        {
            Utilisateur = utilisateur;
           if(Utilisateur!=null)
           {
                TxtNomUtilisateur.Text = utilisateur.Compte;
                TxtMdp.Text = utilisateur.Mot_de_passe;
                TxtNom.Text = utilisateur.Nom_Complet;
                TxtTelephone.Text = utilisateur.Telephone;
                TxtMdp2.Text = utilisateur.Mot_de_passe;
                ComboRole.SelectedItem = /*(short)*/utilisateur.Role;
                //photoUtilisateur.Image =new Bitmap( utilisateur.Photo);
            } 
          
        }
        public void InitForm()
        {
            TxtNomUtilisateur.Text = null;
            TxtMdp.Text = null;
            TxtNom.Text = null;
            TxtTelephone.Text = null;
            TxtMdp2.Text = null;
            ComboRole.SelectedItem = -1;
            photoUtilisateur.ImageLocation = null;

        }

        private void BtnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click_1(object sender, EventArgs e)
        {
           //try
           //{
                CheckForm();
                UtilisateurBLO utilisateurs = new UtilisateurBLO();
                Utilisateur utilisateur = new Utilisateur(TxtNomUtilisateur.Text,
                TxtMdp.Text, TxtNom.Text, null, (Utilisateur.RoleOption)ComboRole.SelectedIndex, TxtTelephone.Text, photoUtilisateur.ImageLocation) ;
                Utilisateur newuser = new Utilisateur(TxtNomUtilisateur.Text,
               TxtMdp.Text, TxtNom.Text, null, (Utilisateur.RoleOption)ComboRole.SelectedIndex, TxtTelephone.Text, photoUtilisateur.ImageLocation) ;

                if (Utilisateur == null)  
                {

                    utilisateurs.Add(utilisateur);
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitForm();
                    UserControls.UserControlGestUtilisateur f = formOwner as UserControls.UserControlGestUtilisateur;
                    f?.LoadData(x => true);

                }
                else
                {
                    newuser = utilisateurs.Edit(utilisateur, newuser);

                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }


           //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            
        }

        private void TxtnomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void BtnSupprimeImage_Click(object sender, EventArgs e)
        {
            photoUtilisateur.ImageLocation = null;
            photoUtilisateur.Refresh();
        }
        private void CheckForm()
        {
            TxtNom.BackColor = TxtNomUtilisateur.BackColor =
                TxtMdp.BackColor = TxtMdp2.BackColor = ComboRole.BackColor = Color.White;
            string error = "";
            if(string.IsNullOrWhiteSpace(TxtNom.Text))
            {
                TxtNom.BackColor = Color.LightPink;
                error += "\n* Nom ne peut pas etre vide!";
            }
            //Regex r = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            //if (!r.IsMatch(TxtNomUtilisateur.Text))
            //{
            //    TxtNomUtilisateur.BackColor = Color.LightPink;
            //    error += "\n* le nom utilisateur doit etre un email!";
            //}
            if (string.IsNullOrWhiteSpace(TxtMdp.Text))
            {
                TxtMdp.BackColor = Color.LightPink;
                error += "\n* Le mot de psser ne  doit pas  etre un vide!";
            }
            if (TxtMdp.Text?.Length<5)
            {
                TxtMdp.BackColor = Color.LightPink;
                error += "\n Le mot de passe doit avoir minimun caractere";
            }
            if(!TxtMdp.Text.Equals(TxtMdp2.Text))
            {
                TxtMdp.BackColor = Color.LightPink;
                TxtMdp2.BackColor = Color.LightPink;
                error += "\n* Mots de passe non correspondant!";
            }
            if (ComboRole.SelectedIndex < 0)
            {
                ComboRole.BackColor = Color.LightPink;
                error += "\n* vous devez choisir un role !";
            }
            if(!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }
        }


        private void BtnAjout_Click(object sender, EventArgs e)
        {
           
        }
        public void Retourneche()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
                ofd.Title = "Choisir une image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    photoUtilisateur.ImageLocation = ofd.FileName;
                    //photoUtilisateur.ImageLocation = ofd.FileName;
                }
            }
        }

        private void PhotoUtilisateur_Click(object sender, EventArgs e)
        {
            Retourneche();
        }
    }
}
