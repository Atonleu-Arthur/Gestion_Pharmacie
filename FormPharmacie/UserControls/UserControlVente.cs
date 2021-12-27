using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using ProjetPharmacie.BO;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlVente : UserControl
    {
        public List<Vente> listeVente = new List<Vente>();
        FormDashboardPharmacie f = new FormDashboardPharmacie();
        private Vente Vente  { get; set; }
        private HistoriqueVente HistoriqueV { get; set; }
        private double SoldeCaisse = 0;
        double Benefice_total = 0;
        double prix_total = 0;
        private string DCI=null;


        public UserControlVente()
        {
            InitializeComponent();
            pardefaut();         
        }
       
        public void pardefaut( )
        {
           
            txtNomCli.Text="Anonyme";

        }
        
        private void UserControlVente_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            FormChoixClient f = new FormChoixClient();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtNomCli.Text = f.Nomcli;
            }
        }

        private void TxtNomCli_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnChoixProduit_Click(object sender, EventArgs e)
        {
            FormChoixProduit f = new FormChoixProduit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DCI = f.Dci;
                txtNomProduit.Text = f.Nomproduit;
                VerificationStock(x => true,f.Nomproduit,f.Dci);
            }

        }


        public void VerificationStock(Func<Achat,bool> predicat,string Nomproduit,string dci) // Methodes pour la verification des quantites en stock
        {
           try
           {
                List<Achat> peremption = new List<Achat>();
                AchatBLO achatBLO = new AchatBLO();
                IEnumerable<Achat> liste = achatBLO.Find(predicat);
                List<Achat> lachats = new List<Achat>(liste);
                List<string> Nom = new List<string>();
                foreach(Achat a in lachats )
                {
                    Nom.Add(a.Nom_medicament);
                }
                if (lachats != null)
                {
                    foreach (Achat a in lachats)
                    {

                        //if (a.Nom_medicament == Nomproduit)
                        //{
                        //    peremption.Add(a);
                        //}
                        //foreach(Achat ua in peremption)
                        //{
                        //    if(ua.Nom_medicament==a.Nom_medicament && Convert.ToDateTime(ua.Date_Expiration)>= Convert.ToDateTime(a.Date_Expiration) && ua.Quantite_stock>0)
                        //    {
                        //        txtNlot.Text = a.Numero_lot.ToString();
                        //        txtPrixdeVente.Text = a.Prix_Vente.ToString();
                        //        txtPeremption.Text = a.Date_Expiration;
                        //        txtStock.Text = a.Quantite_stock.ToString();
                        //    }
                        //    if (Nomproduit == a.Nom_medicament && a.Quantite_stock <= 0)
                        //    {
                        //        MessageBox.Show("Stock Epuisé. Contacter l'administrateur pour la commande d'un nouveau stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        txtNomProduit.Text = null;
                        //    }
                        //else 
                        //{
                        //  MessageBox.Show("Stock Epuisé. Contacter l'administrateur pour la commande d'un nouveau stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //}
                        //}

                        if (Nomproduit == a.Nom_medicament && a.Quantite_stock <= 0)
                        {
                            MessageBox.Show("Un stock de ce produit est épuisé. Contacter l'administrateur pour la commande d'un nouveau stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNomProduit.Text = null;
                        }
                        if (Nomproduit == a.Nom_medicament && a.Quantite_stock > 0 && a.Quantite_stock <= 5)
                        {
                           
                            MessageBox.Show("Le Stock arrive bientot  a épuisement. Penser a le commander !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNlot.Text = a.Numero_lot.ToString();
                        txtPrixdeVente.Text = a.Prix_Vente.ToString();
                        txtPeremption.Text = a.Date_Expiration;
                        txtStock.Text = a.Quantite_stock.ToString();

                        }
                        if (Nomproduit == a.Nom_medicament && a.Quantite_stock >= 5)
                        {
                            txtNomProduit.Text = Nomproduit;

                            txtNlot.Text= a.Numero_lot.ToString() ;
                        txtPrixdeVente.Text = a.Prix_Vente.ToString();
                        txtPeremption.Text = a.Date_Expiration;
                        txtStock.Text = a.Quantite_stock.ToString();
                        }                   
                       
                    }
                    if (!Nom.Contains(Nomproduit))
                    {
                         
                            MessageBox.Show("Produit inexistant ou stock vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNomProduit.Text = null;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Stock totalement vide . Veillez le renouveler", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomProduit.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        public void RetraitenStock(Func<Achat,bool> predicat, Vente vente)
        {
            
            AchatBLO achatBLO = new AchatBLO();
            IEnumerable<Achat> liste = achatBLO.Find(predicat);
            List<Achat> lachats = new List<Achat>(liste);
            if (lachats != null)
            {
                foreach(Achat achat in lachats)
                {

                    Achat newachat = new Achat
                    (
                       achat.Numero_lot, achat.Montant_theorique, achat.Date_achat, achat.Prix_achat, achat.Nom_medicament, achat.Quantite, achat.Prix_total, achat.Quantite_stock,
                       achat.Code_barre, achat.Marge, achat.Prix_Vente, achat.Date_Expiration, achat.Groupe, achat.Rayon, achat.Fournisseur,achat.Quantité_initial

                    );

                    if (vente.Nom_medicament==achat.Nom_medicament && achat.Quantite_stock>vente.Quantite)        
                    {                                                                            
                        achat.Quantite_stock =achat.Quantite_stock - vente.Quantite;               
                        //newachat = achatBLO.Edit(achat, newachat); //  Permet juste de modifier la quantite de l'achat prealablement soustrait  par la quantite vendu dans la base de donne(fichier serialise)
                        listeVente.Add(vente);
                    }
                    if(achat.Quantite_stock < vente.Quantite)
                        MessageBox.Show("La Quantité en Stock est insuffisante", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            if(lachats.Count==0)
            {
                MessageBox.Show("Stock Vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public double CalculBenefice(Func<Achat,bool> predicat,Vente vente)
        {
            AchatBLO achatBLO = new AchatBLO();
            IEnumerable<Achat> liste = achatBLO.Find(predicat);
            List<Achat> lachats = new List<Achat>(liste);
           
            if(lachats!=null)
            {
                foreach(Achat a in lachats)
                {
                    if (vente.Nom_medicament == a.Nom_medicament)
                    {                       
                        
                        vente.Benefice = a.Prix_Vente - a.Prix_achat;
                    }
                }
            }
            return 0;
        }
        public void chargerData()
        {
          
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = listeVente;

            //dataGridView2.DataSource = null;
            //dataGridView2.DataSource = listeVente;
            foreach (Vente a in listeVente)
            {
                prix_total = prix_total + a.Total;
                Benefice_total = Benefice_total + a.Benefice;       // stocke pour l'historique
            }
            lblprixTotal.Text = prix_total.ToString();
        }
        public void InitForm()
        {
            txtNomProduit.Text = null;
            txtNlot.Text = null;
            txtQuantite.Text = null;
            txtPeremption.Text = null;
            txtStock.Text = null;
            txtPrixdeVente.Text = null;

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            //try
            //{
                //int r = 0;
                VenteBLO ventes = new VenteBLO();
                Vente vente = new Vente
                    (

                    txtNomCli.Text, txtNomProduit.Text, DCI,f.txtNom.Text, int.Parse(txtNlot.Text),
                    
                    null, int.Parse(txtStock.Text), int.Parse(txtQuantite.Text),

                    (
                    (int.Parse(txtQuantite.Text)) * (int.Parse(txtPrixdeVente.Text))

                    )
                    , double.Parse(txtPrixdeVente.Text),
                   
                     SoldeCaisse, 0,DateTime.Parse(txtPeremption.Text),DateTime.Now,prix_total

                    );
                if(Vente==null)
                {
                    //RetraitenStock(x => true, vente); // Cette fonction retire la achete quantite en stock et ajoute la vente dans la liste!
                    if ((int.Parse(txtQuantite.Text)) <= (int.Parse(txtStock.Text)))
                    {
                        CalculBenefice(x => true, vente); // Calclule Benefice de chaque vente
                        //if (listeVente.Count > 0)
                        //{
                        //    //foreach (Vente v in listeVente)
                        //    //{
                        //    //    if (v.DCI == DCI)
                        //    //    {
                        //    //        if ((MessageBox.Show("Vente de deux produit ayant une meme DCI. Pour eviter des surdosage ou une mauvaise interraction medicamenteuse veillez vous assurer de cette ordannce. Contiuer la vente ? ", "Attention"
                        //    //                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                        //    //        {
                        //                listeVente.Add(vente);
                        //                r = DataGridView1.RowCount;
                        //                DataGridView1.Rows[r].Cells[0].Style.BackColor = Color.Red;
                        //                chargerData();
                        //                InitForm();
                        //                lblCompteurProduit.Text = DataGridView1.RowCount.ToString();
                        //        //    }
                        //        //}
                        //    //    else
                        //    //    {
                        //    //        listeVente.Add(vente);
                        //    //        chargerData();
                        //    //        InitForm();
                        //    //        lblCompteurProduit.Text = DataGridView1.RowCount.ToString();

                        //    //    }
                        //    ////}
                        //}
                        //else
                        //{
                            listeVente.Add(vente);
                            chargerData();
                            InitForm();
                            lblCompteurProduit.Text = DataGridView1.RowCount.ToString();
                        //}

                    }
                    else
                        MessageBox.Show("La quantité entreé est superieur a la quantité en stock", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                //}
                }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            listeVente.Clear();
        }
        public void EditEQuantite(Func<Achat, bool> predicat, Vente vente)
        {
            test(x => true);
            AchatBLO achatBLO = new AchatBLO();
            test(x => true);
            IEnumerable<Achat> liste = achatBLO.Find(predicat);
            List<Achat> lachats = new List<Achat>(liste);

            if (lachats != null)
            {
                foreach (Achat achat in lachats)
                {
                    test(x => true);

                    listeHist(x => true);
                    if (vente.Nom_medicament == achat.Nom_medicament  && achat.Quantite_stock >= vente.Quantite_vendu /*&& vente.Date_Expiration==achat.Date_Expiration*/)       
                    {                                                                              

                        Achat newachat = new Achat
                    (
                       achat.Numero_lot, achat.Montant_theorique, achat.Date_achat, achat.Prix_achat, achat.Nom_medicament, achat.Quantite, achat.Prix_total, achat.Quantite_stock,
                       achat.Code_barre, achat.Marge, achat.Prix_Vente, achat.Date_Expiration, achat.Groupe, achat.Rayon, achat.Fournisseur,achat.Quantité_initial

                    );
                        achat.Quantite_stock = achat.Quantite_stock - vente.Quantite_vendu;
                        newachat = achatBLO.Edit(newachat, achat); //  Permet juste de modifier la quantite de l'achat prealablement soustrait  par la quantite vendu dans la base de donne(fichier ser
                    }
                }
            }
           
        }

        private void PanelDerniereVente()
        {
            lblNomCli.Text = txtNomCli.Text;
            lblHeure.Text = System.DateTime.Today.Hour.ToString();
            lblTotal.Text = prix_total.ToString();
            lblVerse.Text = txtVersement.Text;
            lblRendu.Text = (double.Parse(txtVersement.Text) - prix_total).ToString();
        }
        private void IniformComplet()
        {
            txtNomProduit.Text = null;
            DataGridView1.DataSource = null;
            lblprixTotal.Text = null;
            lblCompteurProduit.Text = null;
            txtVersement.Text = null;

        }
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            //try
            //{
                //test(x => true);
                //listeHist(x => true);

                VenteBLO ventes = new VenteBLO();
                HistoriqueVenteBLO venteBLO = new HistoriqueVenteBLO();
                HistoriqueVente historique = new HistoriqueVente
                    (
                    DateTime.Now, txtNomCli.Text,f.txtNom.Text,Benefice_total,double.Parse(txtVersement.Text),prix_total

                    ) ;
                //test(x => true);
                //listeHist(x => true);
                foreach (Vente v in listeVente)
                {
                    test(x => true);
                    EditEQuantite(x => true, v); //Modifie la quantite changer dans le fichier

                }
                listeHist(x => true);
                if (HistoriqueV==null)
                {
                    listeHist(x => true);

                    venteBLO.Add(historique);
                    lblRendu1.Text = (double.Parse(txtVersement.Text) - prix_total).ToString();

                   
                }
                MessageBox.Show("Vente Effectuée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReport f1 = new FormReport(historique, listeVente);
                f1.ShowDialog();

            //}
            //catch (Exception ex )
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }
        private void listeHist(Func<HistoriqueVente,bool> predicat)
        {
            HistoriqueVenteBLO venteBLO = new HistoriqueVenteBLO();
            IEnumerable<HistoriqueVente> historiques = venteBLO.Find(predicat);
            MessageBox.Show(historiques.Count().ToString());
        }

        private void Renitialiser_Click(object sender, EventArgs e)
        {
            PanelDerniereVente();
            listeVente.Clear();
            IniformComplet();
        }

        private void BtnChoixProduit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F9)
            {
                FormChoixProduit f = new FormChoixProduit();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DCI = f.Dci;
                    txtNomProduit.Text = f.Nomproduit;
                    VerificationStock(x => true, f.Nomproduit, f.Dci);
                }
            }
        }

        private void test(Func<Achat, bool> predicat)
        {
            AchatBLO achat = new AchatBLO();
            IEnumerable<Achat> achats = achat.Find(predicat);
            MessageBox.Show(achats.Count().ToString());

        }
        private void BtnClient_KeyDown(object sender, KeyEventArgs e)
        {
            FormChoixClient f = new FormChoixClient();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtNomCli.Text = f.Nomcli;
            }
        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                listeVente.Remove(DataGridView1.SelectedRows[0].DataBoundItem as Vente);
                chargerData();
                InitForm();
                lblCompteurProduit.Text = DataGridView1.RowCount.ToString();
            }
            else
                MessageBox.Show("Veillez choisir un élément", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
