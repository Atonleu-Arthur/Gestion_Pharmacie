using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Commande
    {
        public int Id_commande { get; set; }
        private static int count = 0;
        public string Obervation { get; set; }
        public Utilisateur User { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public Medicament Medicament { get; set; }
        public double Quantite_commande { get; set; }
       
        public DateTime Date_commande { get; set; }

        public Commande(string Observation, Utilisateur user, Fournisseur fournisseur, Medicament produit, double quantite_commande, DateTime date_commande)
        {
            Id_commande = count++;
            Obervation = Observation;
            User = user;
            Fournisseur = fournisseur;
            Medicament = produit;
            Quantite_commande = quantite_commande;
            Date_commande = date_commande;
        }

        public Commande(string obervation, Utilisateur user, Fournisseur fournisseur, DateTime date_commande)
        {
            Id_commande = count++;
            Obervation = obervation;
            User = user;
            Fournisseur = fournisseur;
            Date_commande = date_commande;
        }

        public override bool Equals(object obj)
        {
            return obj is Commande commande &&
                   Id_commande == commande.Id_commande;
        }

        public override int GetHashCode()
        {
            return 684427301 + Id_commande.GetHashCode();
        }
    }
}
