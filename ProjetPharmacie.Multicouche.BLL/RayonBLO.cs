using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
   public  class RayonBLO
    {

        private RepositoryFILE<Rayon> Rayondata;
        public RayonBLO()
        {
            Rayondata = new RepositoryFILE<Rayon>();

           
        }
        public Rayon Edit(Rayon oldMedoc, Rayon newMedocs)
        {
            oldMedoc = Rayondata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Rayondata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_rayon);
        }
        public int recupereId(Func<Rayon, bool> predicat, Rayon Rayon)
        {
            RayonBLO achats = new RayonBLO();
            IEnumerable<Rayon> achats1 = achats.Find(predicat);
            foreach (Rayon a in achats1)
            {
                if (Rayon.Id_rayon == a.Id_rayon)
                {
                    Rayon.Id_rayon = Rayon.Id_rayon + 1;
                }
            }
            return 0;
        }
        public void Add(Rayon Rayon)
        {
            recupereId(x => true, Rayon);
            Rayondata.Add(Rayon);
        }

        public IEnumerable<Rayon> Find(Func<Rayon, bool> predicate)
        {
            var data = Rayondata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Rayondata.Find(x => true);
        }
        public void Remove(Rayon Rayon)
        {
            Rayondata.Remove(Rayon);
        }
    }
}
