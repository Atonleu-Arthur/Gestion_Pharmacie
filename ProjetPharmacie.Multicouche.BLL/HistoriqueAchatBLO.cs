using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
  public class HistoriqueAchatBLO
    {
        private RepositoryFILE<HistoriqueAchat> HistoAchatdata;

        public HistoriqueAchatBLO()
        {
            HistoAchatdata = new RepositoryFILE<HistoriqueAchat>();
        }
        public HistoriqueAchat Edit(HistoriqueAchat oldachat, HistoriqueAchat newachat)
        {
            oldachat = HistoAchatdata.Get(newachat);
            if (oldachat != null)
            {
                return HistoAchatdata.Edit(oldachat, newachat);
            }
            throw new KeyNotFoundException(oldachat?.Id_Achat.ToString());
        }
        public int recupereId(Func<HistoriqueAchat, bool> predicat, HistoriqueAchat achat)
        {
            HistoriqueAchatBLO achats = new HistoriqueAchatBLO();
            IEnumerable<HistoriqueAchat> achats1 = achats.Find(predicat);
            foreach (HistoriqueAchat a in achats1)
            {
                if (achat.Id_Historique == a.Id_Historique)
                {
                    achat.Id_Historique = achat.Id_Historique + 1;
                }
            }
            return 0;
        }
        public void Add(HistoriqueAchat achat)
        {
            recupereId(x => true, achat);
            HistoAchatdata.Add(achat);
        }

        public IEnumerable<HistoriqueAchat> Find(Func<HistoriqueAchat, bool> predicate)
        {
            var data = HistoAchatdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            HistoAchatdata.Find(x => true);
        }
        public void Remove(HistoriqueAchat achat)
        {
            HistoAchatdata.Remove(achat);
        }

    }


}
