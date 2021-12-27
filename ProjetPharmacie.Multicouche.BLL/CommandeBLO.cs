using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.Multicouche.BLL
{
   public  class CommandeBLO
    {

        private RepositoryFILE<Commande> Commandedata;

        public CommandeBLO()
        {
            Commandedata = new RepositoryFILE<Commande>();

            var count = Commandedata.Find(x => true).Count();
            if (count == 0)
            {
             
            }

        }
        public Commande Edit(Commande oldcommande, Commande newcommande)
        {
            oldcommande = Commandedata.Get(newcommande);
            if (oldcommande != null)
            {
                return Commandedata.Edit(oldcommande, newcommande);
            }
            throw new KeyNotFoundException(oldcommande?.Id_commande.ToString());
        }
        public int recupereId(Func<Commande, bool> predicat, Commande commande)
        {
            CommandeBLO achats = new CommandeBLO();
            IEnumerable<Commande> achats1 = achats.Find(predicat);
            foreach (Commande a in achats1)
            {
                if (a.Id_commande == a.Id_commande)
                {
                    a.Id_commande = commande.Id_commande + 1;
                }
            }
            return 0;
        }
        public void Add(Commande commande)
        {
            recupereId(x => true, commande);
            Commandedata.Add(commande);
        }

        public IEnumerable<Commande> Find(Func<Commande, bool> predicate)
        {
            var data = Commandedata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Commandedata.Find(x => true);
        }
        public void Remove(Commande commande)
        {
             Commandedata.Remove(commande);
        }

    }
}
