using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
    public class HistoriqueCommandeBLO
    {
        private RepositoryFILE<HistoriqueCommande> HistoAchatdata;

        public HistoriqueCommandeBLO()
        {
            HistoAchatdata = new RepositoryFILE<HistoriqueCommande>();
        }

        public int recupereId(Func<HistoriqueCommande, bool> predicat, HistoriqueCommande vente)
        {
            HistoriqueCommandeBLO achats = new HistoriqueCommandeBLO();
            IEnumerable<HistoriqueCommande> achats1 = achats.Find(predicat);
            foreach (HistoriqueCommande a in achats1)
            {
                if (vente.Id_HistCommande == a.Id_HistCommande)
                {
                    vente.Id_HistCommande = vente.Id_HistCommande + 1;
                }
            }
            return 0;
        }
        public void Add(HistoriqueCommande commande)
        {
            recupereId(x => true, commande);
            HistoAchatdata.Add(commande);
        }

        public IEnumerable<HistoriqueCommande> Find(Func<HistoriqueCommande, bool> predicate)
        {
            var data = HistoAchatdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            HistoAchatdata.Find(x => true);
        }
        public void Remove(HistoriqueCommande commande)
        {
            HistoAchatdata.Remove(commande);
        }
    }
}
