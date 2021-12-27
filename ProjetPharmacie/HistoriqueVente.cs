using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
  public  class HistoriqueVente : Vente
    {
        private static int VCount = 0;
        public int Id_HistoriqueV  { get; set; }
        public double Total_Benefice  { get; set; }
        public double Total_Averse  { get; set; }
        public double Versement  { get; set; }

        public HistoriqueVente(DateTime date_vente,string client,string user,double total_Benefice, double versement ,double total_Averse) : base(client,user ,date_vente)
        {
            Id_HistoriqueV = VCount++;
            Total_Averse = total_Averse;
            Total_Benefice = total_Benefice;
            Versement = versement;
        }

        public override bool Equals(object obj)
        {
          return  (obj as HistoriqueVente)?.Id_HistoriqueV.Equals(this.Id_HistoriqueV) ?? false;

        }

        public override int GetHashCode()
        {
            return Id_HistoriqueV.GetHashCode();
           
        }
    }
}
