using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Vente : Achat
    {
        public int Id_vente { get; set; }
        private static int Count = 0;
        public string Client { get; set; }
        public double Total { get; set; }
        public string Utilisateur  { get; set; }       
        public double Solde_Caisse { get; set; }
        public double Benefice { get; set; }
        public double Prix_vente { get; set; }
        public DateTime Date_vente { get; set; }
        public int Quantite_vendu { get; set; }
        public double VersmentV  { get; set; }


        public Vente(string client, string nom, string dci, string utilisateur, int numero_lot, Rayon rayon, int quantite_stock,
            int quantite, double total, double prix_vente, double solde_Caisse, double benefice, DateTime date_expiration, DateTime date_vente,double versement)
            : base(nom, numero_lot, prix_vente, rayon, quantite_stock, dci, date_expiration)
        {
            Id_vente = Count++;
            Client = client;
            Quantite_vendu = quantite;
            Total = total;
            Utilisateur = utilisateur;
            Solde_Caisse = solde_Caisse;
            Benefice = benefice;
            Prix_vente = prix_vente;
            Date_vente = date_vente;
            VersmentV = versement;
        }

        public Vente(string client, string user,  DateTime date_vente): base()
        {
            Id_vente = Count++;
            Client = client;
            Utilisateur = user;
            Date_vente = date_vente;
        }

        public override bool Equals(object obj)
        {
            return obj is Vente vente &&
                   Id_vente == vente.Id_vente;
        }

        public override int GetHashCode()
        {
            return  Id_vente.GetHashCode();
        }
    }
}
