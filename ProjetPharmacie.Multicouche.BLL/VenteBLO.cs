using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
   public class VenteBLO
    {
        private RepositoryFILE<Vente> Ventedata;

        public VenteBLO()
        {
            Ventedata = new RepositoryFILE<Vente>();

            var count = Ventedata.Find(x => true).Count();
            if (count == 0)
            {
                List<Vente> Ventes = new List<Vente>
                {
                    //new Vente(123,)
                };
                foreach (Vente u in Ventes)
                {
                    Ventedata.Add(u);
                }
            }

        }
        public Vente Edit(Vente oldVente, Vente newVente)
        {
            oldVente = Ventedata.Get(newVente);
            if (oldVente != null)
            {
                return Ventedata.Edit(oldVente, newVente);
            }
            throw new KeyNotFoundException(oldVente?.Id_vente.ToString());
        }
        public int recupereId(Func<Vente, bool> predicat, Vente vente)
        {
            VenteBLO achats = new VenteBLO();
            IEnumerable<Vente> achats1 = achats.Find(predicat);
            foreach (Vente a in achats1)
            {
                if (vente.Id_vente == a.Id_vente)
                {
                    vente.Id_vente = vente.Id_vente + 1;
                }
            }
            return 0;
        }
        public void Add(Vente Vente)
        {
            recupereId(x => true, Vente);
            Ventedata.Add(Vente);
        }

        public IEnumerable<Vente> Find(Func<Vente, bool> predicate)
        {
            var data = Ventedata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Ventedata.Find(x => true);
        }
        public void Remove(Vente Vente)
        {
            Ventedata.Remove(Vente);
        }

    }
}
