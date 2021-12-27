using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
   public class HistoriqueCommande : Commande
    {
        public int Id_HistCommande  { get; set; }
        private static int count = 0;
        public double Total_produit  { get; set; }
        public HistoriqueCommande(string observation ,Utilisateur user,Fournisseur fournisseur,DateTime date_commande , double total_produit ) : base(observation ,user,fournisseur,date_commande)
        {
            Id_HistCommande = count++;
            Total_produit = total_produit;
        }
        
    }
}
