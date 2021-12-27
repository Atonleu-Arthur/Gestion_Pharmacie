using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
    public class Achat : Produit
    {
        public int Id_Achat { get; set; }
        private static int Acount = 0;
        public Utilisateur User { get; set; } // me sera utile pour configuer le Mouchard
        public double Montant_theorique { get; set; }
        public double Prix_total { get; set; }
        public DateTime Date_achat { get; set; }
        public double Difference  { get; set; }
        public double Prix_totalPPA { get; set; }
        public int Quantité_initial  { get; set; }



        public Achat(int numero_lot, double montant_theorique, DateTime date_achat, double prix_achat, string nom,
          int quantite, double prix_total, int quantite_stock, double code_barre, int marge, double prix_Vente,  string date_Expiration,Groupe groupe,
            Rayon rayon, Fournisseur fournisseur,int quantité_initial) : base(nom,quantite, code_barre, prix_Vente, marge, quantite_stock, date_Expiration ,groupe, rayon, fournisseur, prix_achat)
        {

            Id_Achat = Acount++;
            Numero_lot = numero_lot;
            Date_achat = date_achat;
            Montant_theorique = montant_theorique;
            Prix_total = prix_total;
            Quantité_initial = quantité_initial;
         

        }

        public Achat(string nom ,int numero_lot, double prix_Vente, Rayon rayon, int quantite_stock,string dCI,DateTime date_expiration) :base(nom,prix_Vente,rayon,quantite_stock,numero_lot,dCI,date_expiration)
        {
            Id_Achat =  Acount++;
        }

        public Achat()
        {
        }

        public Achat(string nom) : base(nom)
        {
            Id_Achat = Acount++;
        }

     
        public Achat( DateTime date_achat, double montant_theorique, double difference, double prix_total, Fournisseur fournisseur, double prix_totalppa) : base(fournisseur)
        {
            Id_Achat = 0;
            Difference = difference;
            Montant_theorique = montant_theorique;
            Prix_total = prix_total;
            Date_achat = date_achat;
            Prix_totalPPA = prix_totalppa;
        }

      
        public override bool Equals(object obj)
        {
            return (obj as Achat)?.Id_Achat.Equals(this.Id_Achat) ?? false;
        }

        public override int GetHashCode()
        {
            return Id_Achat.GetHashCode();
        }

    }
}
