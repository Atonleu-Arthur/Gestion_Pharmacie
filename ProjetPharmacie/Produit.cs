using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public abstract class Produit : Medicament
    {
       
        public int Quantie_initial { get; set; }

        public static int count = 0;
        public int Id_Produit  { get; set; }
        public double Code_barre { get; set; }     
        public double Prix_Vente { get; set; }
        public int Quantite_alerte { get; set; }
        public string  Date_Expiration { get; set; }
        public Rayon Rayon  { get; set; }
        public Fournisseur Fournisseur  { get; set; }
        public int Quantite_stock  { get; set; }
        public int Numero_lot { get; set; }
        public double Ppa { get; set; }
        public double Prix_achat  { get; set; }
        public int Quantite { get; set; }
        public int Marge  { get; set; }


    

        public Produit()
        {
        }

        public Produit(string nom, double prix_Vente, Rayon rayon, int quantite_stock, int numero_lot,string dCI,DateTime date_expiration): base(nom,dCI)
        {
            Prix_Vente = prix_Vente;
            Rayon = rayon;
            Quantite_stock = quantite_stock;
            Numero_lot = numero_lot;
            Nom_medicament = nom;
        }

        public Produit(string nom,double prix_Vente, string date_Expiration, Rayon rayon, int quantite_stock, int numero_lot,string dci) : base(nom,dci)
        {
            Prix_Vente = prix_Vente;
            Date_Expiration = date_Expiration;
            Rayon = rayon;
            Quantite_stock = quantite_stock;
            Numero_lot = numero_lot;
        }

        public Produit(string nom,int quantite, double code_barre, double prix_Vente,int marge, int quantite_stock, string date_Expiration, Groupe groupe,Rayon rayon, Fournisseur fournisseur,double prix_achat)
            : base(nom,groupe)
        {
            //Quantie_initial = quantie_initial;
            Id_Produit = count++;
            Marge = marge;
            Code_barre = code_barre;
            Prix_Vente = prix_Vente;
            Quantite = quantite;
            Quantite_stock =quantite_stock;
            Date_Expiration = date_Expiration;
            Rayon = rayon;
            Fournisseur = fournisseur;
            Prix_achat = prix_achat;
        }

        public Produit(Fournisseur fournisseur) :base()
        {
            Fournisseur = fournisseur;
        }
        public Produit(string nom) : base(nom)
        {

        }
      
      
       

        public override bool Equals(object obj)
        {
            return (obj as Produit)?.Id_Produit.Equals(this.Id_Produit) ?? false;

        }

        public override int GetHashCode()
        {
            return Id_Produit.GetHashCode();
        }
        public override string ToString()
        {
            return Nom_medicament;
        }
    }
}
