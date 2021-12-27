using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
   public class HistoriqueAchat : Achat
    {
        public int Id_Historique  { get; set; }
        private static int Hcount = 0;

        public HistoriqueAchat(DateTime date_achat,double montant_theorique,double difference,double prix_total,Fournisseur fournisseur,double prix_totalppa):base(date_achat,montant_theorique,difference,prix_total, fournisseur, prix_totalppa)
        {
            Id_Historique = Hcount++;

        }

        public override bool Equals(object obj)
        {
            return (obj as HistoriqueAchat)?.Id_Historique.Equals(this.Id_Historique) ?? false;

        }

        public override int GetHashCode()
        {
            return Id_Historique.GetHashCode();
        }
    }
}
