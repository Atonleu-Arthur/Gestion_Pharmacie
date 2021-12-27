using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
  public class HistoriqueVenteBLO
    {
        private RepositoryFILE<HistoriqueVente> HistoVentedata;

        public HistoriqueVenteBLO()
        {
            HistoVentedata = new RepositoryFILE<HistoriqueVente>();
        }
        public HistoriqueVente Edit(HistoriqueVente oldhvente, HistoriqueVente newhvente)
        {
            oldhvente = HistoVentedata.Get(newhvente);
            if (oldhvente != null)
            {
                return HistoVentedata.Edit(oldhvente, newhvente);
            }
            throw new KeyNotFoundException(oldhvente?.Id_HistoriqueV.ToString());
        }
        public int recupereId(Func<HistoriqueVente, bool> predicat, HistoriqueVente vente)
        {
            HistoriqueVenteBLO achats = new HistoriqueVenteBLO();
            IEnumerable<HistoriqueVente> achats1 = achats.Find(predicat);
            foreach (HistoriqueVente a in achats1)
            {
                if (vente.Id_HistoriqueV == a.Id_HistoriqueV)
                {
                    vente.Id_HistoriqueV = vente.Id_HistoriqueV + 1;
                }
            }
            return 0;
        }

        public void Add(HistoriqueVente hvente)
        {
            recupereId(x => true, hvente);
            HistoVentedata.Add(hvente);
        }

        public IEnumerable<HistoriqueVente> Find(Func<HistoriqueVente, bool> predicate)
        {
            var data = HistoVentedata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            HistoVentedata.Find(x => true);
        }
        public void Remove(HistoriqueVente hvente)
        {
            HistoVentedata.Remove(hvente);
        }
    }
}
