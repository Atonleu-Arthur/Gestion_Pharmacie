using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
    public class PharmacieBLO
    {
        private RepositoryFILE<Pharmacie> Pharmaciedata;
        public PharmacieBLO()
        {
            Pharmaciedata = new RepositoryFILE<Pharmacie>();


        }
        public Pharmacie Edit(Pharmacie oldMedoc, Pharmacie newMedocs)
        {
            oldMedoc = Pharmaciedata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Pharmaciedata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_pharmacie);
        }
      
        public void Add(Pharmacie Pharmacie)
        {
            Pharmaciedata.Add(Pharmacie);
        }

    }
}
