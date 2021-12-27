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
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlAchat : UserControl
    {
        private Produit Produit { get; set; }
        private Groupe Groupe { get; set; }
        private Achat Achat { get; set; }
        public Produit produit;
        List<Achat> listeachat = new List<Achat>();

        public HistoriqueAchat HistoriqueAchat { get; set; }

        private Form formOwner  { get; set; }
        private List<Utilisateur> liste;
        
        public UserControlAchat()
        {
            InitializeComponent();
            LoadDataM(x => true, null);
        }
        public UserControlAchat(Form owner)
        {
            InitializeComponent();
            LoadDataM(x => true, null);
            formOwner = owner;
        }
       public Utilisateur LoadataUser(Func<Utilisateur,bool> predicat,int index)
        {
            
            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            IEnumerable<Utilisateur> utl = utilisateurs.Find(predicat);
            if(utl!=null)
            {
                liste = new List<Utilisateur>(utl);

            }
            
            return liste[index];

        }
        public void LoadDataM(Func<Fournisseur, bool> predicat,Fournisseur fournisseur)
        {

            FournisseurBLO fournisseurs = new FournisseurBLO();
            IEnumerable<Fournisseur> us = fournisseurs.Find(predicat);

            if (us != null)
            {
                List<Fournisseur> liste = new List<Fournisseur>(us);
                liste.Add(new Fournisseur("<New Fournisseur>", "0", 0));
               
                    ComboBoxFournisseur.DataSource = liste;
                    comboBox.DataSource = liste;
                    if (fournisseur != null)
                {

                    ComboBoxFournisseur.SelectedItem = fournisseur;
                    comboBox.SelectedItem = fournisseur;
                }
                    else
                {

                    ComboBoxFournisseur.SelectedIndex = -1;
                    comboBox.SelectedIndex = -1;
                }

                //}
            }
        }
        public void LoadataAchat(Func<Achat,bool> predicat)
        {
            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> achats1 = achats.Find(predicat);
            RefreshGrid();
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = achats1;


        }
        public void InitForm()
        {
            TxtCodeBarre.Text = null;
            TxtPrixAchat.Text = null;
            TxtProduit.Text = null;
            txtNLot.Text = null;
            txtPPA.Text = null;
            txtPPA.Text = null;
            txtQuantite.Text = null;
            
        }
        public int Ajoutstosk(Func<Achat, bool> predicate, Achat achat) // augmenter la quantite en stock lors de l'ajout d'un nouvel  achat
        {

            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> liste = achats.Find(predicate);
            List<Achat> liste2 = new List<Achat>(liste);
            if (liste2.Count>0  && achat != null)
            {
                foreach (Achat a in liste)
                {
                    //if (a.Nom_medicament == achat.Nom_medicament && a.Prix_achat == achat.Prix_achat && a.Fournisseur.ToString() == achat.Fournisseur.ToString() && a.Date_Expiration != achat.Date_Expiration)
                    //    return achat.Quantite_stock = achat.Quantite_stock;

                    if (a.Nom_medicament == achat.Nom_medicament && a.Fournisseur.ToString() == achat.Fournisseur.ToString() && a.Prix_achat == achat.Prix_achat && a.Date_Expiration==achat.Date_Expiration)
                        return achat.Quantite_stock = a.Quantite_stock + achat.Quantite;
                    else
                       return achat.Quantite_stock = achat.Quantite;

                }

                petittest(x => true);

            }

            if (liste2.Count == 0)
            {

                return achat.Quantite_stock = achat.Quantite;



            }
            return 0;
        }
        public void RefreshGrid()
        {
            DataGridView1.DataSource = null;
            lblCompteurProduit.Text = null;
            lblTotalPPa.Text = null;
            lblToatalPaye.Text = null;
            lblDif.Text = null;
             

        }
     
        public void tesobligatoire()
        {
            if (TxtCodeBarre.Text == null || TxtPrixAchat.Text == null  || TxtProduit.Text == null  || txtNLot.Text ==null||  txtPPA.Text== null|| txtPPA.Text == null||  txtQuantite.Text == null)
            {
                MessageBox.Show("Veillez completer tous les champs s'il vous plait", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ComboBoxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
       
          
        }
        public void InitormAffiche()
        {
            if (ComboBoxFournisseur.SelectedIndex == -1)
                MessageBox.Show("Veillez choisir un fourniseur", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (txtMontantTHq.Text == null)
                MessageBox.Show("Veillez entrer un montant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(txtNLot.Text==null)
                MessageBox.Show("Veillez entrer un numero de lot", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(TxtExpi.Text==null)
                MessageBox.Show("Veillez entrer une date d'expiration", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void TxtProduit_TextChanged(object sender, EventArgs e)
        {
        }
         public void chargerData()
        {
            double prix_total = 0;
            double PPa = 0;
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = listeachat;
            foreach(Achat a in listeachat)
            {
                prix_total = prix_total + a.Prix_total;
                PPa = PPa + a.Prix_Vente;

            }
            lblToatalPaye.Text = prix_total.ToString();
            lblTotalPPa.Text = PPa.ToString();
            lblDif.Text = ((double.Parse(txtMontantTHq.Text)) - prix_total).ToString();
        }
       

        private void UserControlAchat_Load(object sender, EventArgs e)
        {
        }

       

        public void LoadataEditStock(Func<Achat,bool> predicat,Achat achat)
        {
            
            AchatBLO achats = new AchatBLO();
            //petittest(x => true);
            //petittesth(x => true);

            IEnumerable<Achat> Elisteachat = achats.Find(predicat);
            List<Achat> achats1 = new List<Achat>(Elisteachat);
            //petittest(x => true);
            //petittesth(x => true);

            if (achats1!=null)
            {

                //petittest(x => true);
                //petittesth(x => true);

                foreach (Achat a in achats1)
                {
                    if (a.Nom_medicament == achat.Nom_medicament && a.Fournisseur.ToString() == achat.Fournisseur.ToString() && a.Prix_achat == achat.Prix_achat && a.Date_Expiration == achat.Date_Expiration)

                    {
                        //petittest(x => true);
                        //petittesth(x => true);

                        Achat newachat = new Achat
                         (
                            achat.Numero_lot, achat.Montant_theorique, achat.Date_achat, achat.Prix_achat, achat.Nom_medicament, achat.Quantite, achat.Prix_total, achat.Quantite_stock,
                            achat.Code_barre, achat.Marge, achat.Prix_Vente, achat.Date_Expiration, achat.Groupe, achat.Rayon, achat.Fournisseur, petittest(x => true)


                         );
                        newachat = achats.Edit(achat, newachat);
                    }
                  
                      //petittest(x => true);
                    //petittesth(x => true);

                }
                //if (achats1.Count>0)
                //    achats.Add(achat);

            }
          

            if (achats1.Count > 0)
                achats.Add(achat);
           else
                achats.Add(achat);



        }
       

     

    
      
        public int petittest(Func<Achat,bool> predicat)
        {
            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> Elisteachat = achats.Find(predicat);
            return Elisteachat.Count();
        }
        public void petittesth(Func<HistoriqueAchat, bool> predicat)
        {
            HistoriqueAchatBLO achats = new HistoriqueAchatBLO();
            IEnumerable<HistoriqueAchat> Elisteachat = achats.Find(predicat);
            MessageBox.Show(Elisteachat.Count().ToString());
        }

        private void GunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

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
            UserControlAchatp user = new UserControlAchatp();
            AddControlTopanel(user);
        }

        private void BtnChoixP_Click_1(object sender, EventArgs e)
        {
            FormChoixProduit f = new FormChoixProduit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                TxtProduit.Text = f.Nomproduit;
                Groupe = f.Groupe;

            }
        }

        private void Btnvalider_Click_1(object sender, EventArgs e)
        {
            try
            {
                Achat newachat = new Achat
                    (
                     int.Parse(txtNLot.Text), double.Parse(txtMontantTHq.Text), DateTime.Now, double.Parse(TxtPrixAchat.Text), TxtProduit.Text, int.Parse(txtQuantite.Text),
                     ((int.Parse(txtQuantite.Text)) * (int.Parse(TxtPrixAchat.Text))), 0, 0, int.Parse(txtMarge.Text),

                        //   (

                        //((int.Parse(TxtPrixAchat.Text)) * (int.Parse(txtMarge.Text))) / 100
                        //  ) + (int.Parse(TxtPrixAchat.Text)), 

                        (

                  ((int.Parse(txtPPA.Text)) - (int.Parse(TxtPrixAchat.Text))) * 100
                    ) / (int.Parse(TxtPrixAchat.Text)),

                     TxtExpi.Text, Groupe, null, (Fournisseur)comboBox.SelectedItem,petittest(x=>true)


                    );

                if (Achat == null)
                {
                    newachat.Quantite_stock = Ajoutstosk(x => true, newachat);
                    MessageBox.Show(newachat.Quantite_stock.ToString());
                    //tesobligatoire();
                    InitormAffiche();
                    listeachat.Add(newachat);
                    chargerData();
                    InitForm();
                    lblCompteurProduit.Text = DataGridView1.RowCount.ToString();
                  

                    MessageBox.Show("Ajout réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Veillez entrer uniquement des nombre ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce produit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Achat achat = null;
                    for (int i = 0; i < DataGridView1.SelectedRows.Count; i++)
                    {
                        achat = DataGridView1.SelectedRows[i].DataBoundItem as Achat;
                        listeachat.Remove(achat);

                    }
                    RefreshGrid();
                }
            }
        }

        private void BtnAnnuler_Click_1(object sender, EventArgs e)
        {
            listeachat.Clear();
            RefreshGrid();
        }

        private void TxtMarge_TextChanged_1(object sender, EventArgs e)
        {
            //try
            //{
            //    int marge = int.Parse(txtMarge.Text);
            //    int prixachat = int.Parse(TxtPrixAchat.Text);
            //    txtPPA.Text = (((prixachat * marge) / 100) + prixachat).ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("La marge ne peut etre vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            petittest(x => true);
            petittesth(x => true);


            HistoriqueAchatBLO achatS = new HistoriqueAchatBLO();
            HistoriqueAchat hachat = new HistoriqueAchat(DateTime.Now, double.Parse(txtMontantTHq.Text), double.Parse(lblDif.Text),
                double.Parse(lblToatalPaye.Text), (Fournisseur)comboBox.SelectedItem, double.Parse(lblTotalPPa.Text));
            petittest(x => true);

            try
            {
                foreach (Achat a in listeachat)
                {
                    // Ajout d'une fonction de verification car l'ajout d'un produit en stock qui existe deja modifie juste sa 
                    //quantite dans le stock donc on peut plus l'ajouter dans la liste on doit le modifier d'ou cette methode
                    LoadataEditStock(x => true, a);
                    petittest(x => true);
                    petittesth(x => true);


                }
                if (HistoriqueAchat == null)
                {
                    achatS.Add(hachat);
                }
                listeachat.Clear();
                petittesth(x => true);

                RefreshGrid();

                MessageBox.Show("Achat effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ComboBoxFournisseur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBoxFournisseur.SelectedIndex == ComboBoxFournisseur.Items.Count - 1)
            {
                Func<Fournisseur, bool> predicat = x => true;
                FournisseurBLO fournisseur = new FournisseurBLO();
                FormAjoutFournisseur f = new FormAjoutFournisseur(new UserControlFournisseur());
                f.BtnValider.DialogResult = DialogResult.OK;
                f.BtnQuitter.DialogResult = DialogResult.Cancel;
                IEnumerable<Fournisseur> us = fournisseur.Find(predicat);
                List<Fournisseur> liste = new List<Fournisseur>(us);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (liste.Count > 1)
                    {
                        LoadDataM(x => true, liste[liste.Count - 1]);
                    }
                }
                else
                {
                    if (Produit != null)
                    {
                        ComboBoxFournisseur.SelectedItem = Produit.Fournisseur;
                    }
                    else
                    {
                        ComboBoxFournisseur.SelectedItem = -1;
                    }

                }
            }
        }

        private void TxtPPA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int prixachat = int.Parse(TxtPrixAchat.Text);
                txtMarge.Text = (((int.Parse(txtPPA.Text) - prixachat) * 100) / prixachat).ToString();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Le prix de vente ne peut etre vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

}
    }
}
