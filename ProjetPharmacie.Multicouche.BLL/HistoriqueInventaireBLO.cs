using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
  public  class HistoriqueInventaireBLO
    {
        private RepositoryFILE<HistoriqueInventaire> HistoriqueInventairedata;
        public HistoriqueInventaireBLO()
        {
            HistoriqueInventairedata = new RepositoryFILE<HistoriqueInventaire>();


        }
        public HistoriqueInventaire Edit(HistoriqueInventaire oldMedoc, HistoriqueInventaire newMedocs)
        {
            oldMedoc = HistoriqueInventairedata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return HistoriqueInventairedata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Observation);
        }
        public int recupereId(Func<HistoriqueInventaire, bool> predicat, HistoriqueInventaire HistoriqueInventaire)
        {
            HistoriqueInventaireBLO achats = new HistoriqueInventaireBLO();
            IEnumerable<HistoriqueInventaire> achats1 = achats.Find(predicat);
            foreach (HistoriqueInventaire a in achats1)
            {
                if (HistoriqueInventaire.Id_Historique == a.Id_Historique)
                {
                    HistoriqueInventaire.Id_Historique = HistoriqueInventaire.Id_Historique + 1;

                }
            }
            return 0;
        }
        public void Add(HistoriqueInventaire HistoriqueInventaire)
        {
            recupereId(x => true, HistoriqueInventaire);
            HistoriqueInventairedata.Add(HistoriqueInventaire);
        }
        public IEnumerable<HistoriqueInventaire> Find(Func<HistoriqueInventaire, bool> predicate)
        {
            var data = HistoriqueInventairedata.Find(predicate);

            return data;
        }

    }
}
