using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
   public class AchatBLO
    {
        private RepositoryFILE<Achat> Achatdata;

        public AchatBLO()
        {
            Achatdata = new RepositoryFILE<Achat>();

            var count = Achatdata.Find(x => true).Count();
            if (count == 0)
            {
                List<Achat> achats = new List<Achat>
                {
                    //new Achat(123,)
                };
                foreach (Achat u in achats)
                {
                    Achatdata.Add(u);
                }
            }

        }
        public Achat Edit(Achat oldachat, Achat newachat)
        {
            oldachat = Achatdata.Get(newachat);
            if (oldachat != null)
            {
                return Achatdata.Edit(oldachat, newachat);
            }
            throw new KeyNotFoundException(oldachat?.Id_Achat.ToString());
        }

        public void Add(Achat achat)
        {
            recupereId(x => true, achat);
            Achatdata.Add(achat);
        }
        public int recupereId(Func<Achat, bool> predicat,Achat achat)
        {
            AchatBLO achats = new AchatBLO();
            IEnumerable<Achat> achats1 = achats.Find(predicat);
            foreach(Achat a in achats1)
            {
                if(achat.Id_Achat==a.Id_Achat)
                {
                    achat.Id_Achat = achat.Id_Achat +1;
                }
            }
            return 0;
        }
        public IEnumerable<Achat> Find(Func<Achat, bool> predicate)
        {
            var data = Achatdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Achatdata.Find(x => true);
        }
        public void Remove(Achat achat)
        {
            Achatdata.Remove(achat);
        }

    }
}
