using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;
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
    public partial class FormEditQuantiteInve : Form
    {
        public UserControl UserControl;
        public Achat Achat  { get; set; }

        public FormEditQuantiteInve(UserControl userControl)
        {
            InitializeComponent();
            UserControl = userControl;
        }
        public FormEditQuantiteInve(UserControl userControl , Achat achat) :this(userControl)
        {
            Achat = achat;
            if(Achat!=null)
            {
                NomMedoc.Text = achat.Nom_medicament;
                lbllot.Text = achat.Numero_lot.ToString();
                lblPerem.Text = achat.Date_Expiration.ToString();
                lblprixppa.Text = achat.Prix_Vente.ToString();
                lblquanth.Text = achat.Quantite.ToString();
                txtQuantitePhy.Text = achat.Quantite_stock.ToString();
            }
        }

        public void Loadata(Func<Achat ,bool> predicat, Achat achat)
        {
            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> achats1 = achats.Find(predicat);
            List<Achat> achats2 = new List<Achat>(achats1);
            foreach(Achat a in achats2 )
            {
                

                if (achat.Nom_medicament==a.Nom_medicament && achat.Numero_lot==a.Numero_lot)
                {
                    Achat newachat = new Achat
                         (
                            a.Numero_lot, a.Montant_theorique, a.Date_achat, a.Prix_achat, a.Nom_medicament, a.Quantite, a.Prix_total, achat.Quantite_stock,
                            a.Code_barre, a.Marge, a.Prix_Vente, a.Date_Expiration, a.Groupe, a.Rayon, a.Fournisseur, petittest(x => true)


                         );
                    newachat = achats.Edit(achat, newachat);
                }
            }

        }
        public int petittest(Func<Achat, bool> predicat)
        {
            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> Elisteachat = achats.Find(predicat);
            return Elisteachat.Count();
        }
        private void BtnEnregistrer1_Click(object sender, EventArgs e)
        {
            HistoriqueInventaireBLO historiqueInventaire = new HistoriqueInventaireBLO();
            HistoriqueInventaire historique = new HistoriqueInventaire
                (int.Parse(lbllot.Text), lblPerem.Text, lblprixppa.Text, int.Parse(lblquanth.Text),int.Parse( txtQuantitePhy.Text),ComboboxRayon.SelectedItem.ToString(),txtObservation.Text

                ) ;
            historiqueInventaire.Add(historique);
        }

        private void FormEditQuantiteInve_Load(object sender, EventArgs e)
        {

        }
    }
}
