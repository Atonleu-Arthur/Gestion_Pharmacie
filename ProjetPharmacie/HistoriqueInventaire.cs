using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
   public class HistoriqueInventaire
    {
        public int Id_Historique  { get; set; }
        public int Lot { get; set; }
        public string Date  { get; set; }
        public string PrixVente  { get; set; }
        public int Quantite_initiale { get; set; }
        public int Quantite_theorique { get; set; }
        public string Motif  { get; set; }
        public string Observation { get; set; }

        public HistoriqueInventaire(int lot, string date, string prixVente, int quantite_initiale, int quantite_theorique, string motif, string observation)
        {
            Id_Historique = 0;
            Lot = lot;
            Date = date;
            PrixVente = prixVente;
            Quantite_initiale = quantite_initiale;
            Quantite_theorique = quantite_theorique;
            Motif = motif;
            Observation = observation;
        }

        public override bool Equals(object obj)
        {
            return obj is HistoriqueInventaire inventaire &&
                   Id_Historique == inventaire.Id_Historique;
        }

        public override int GetHashCode()
        {
            return Id_Historique.GetHashCode();
        }
    }
}
