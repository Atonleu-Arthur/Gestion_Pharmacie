using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProjetPharmacie.BO;
using System.Collections;
using ProjetPharmacie.Multicouche.DAL;


namespace ProjetPharmacie.Multicouche.DAL
{
    public class GroupeBLO
    {
        private RepositoryFILE<Groupe> Groupedata;
        public GroupeBLO()
        {
            Groupedata = new RepositoryFILE<Groupe>();

            var count = Groupedata.Find(x => true).Count();
            if (count == 0)
            {
                List<Groupe> groupes = new List<Groupe>
                {
                    new Groupe("Médicament oraux ou rectal"),
                    new Groupe("Médicament injectables"),
                    new Groupe("Solutés de perfusion"),
                    new Groupe("Vaccins , immonoglobulines et sérums"),
                     new Groupe("Médicaments à usage externe et antiseptiques"),
                     new Groupe("Désinfectant")

                };
                  foreach(Groupe g in groupes)
                {
                    Groupedata.Add(g);
                }
            }

        }
        public Groupe Edit(Groupe oldMedoc, Groupe newMedocs)
        {
            oldMedoc = Groupedata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Groupedata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_groupe);
        }

        public void Add(Groupe groupe)
        {
            Groupedata.Add(groupe);
        }

        public IEnumerable<Groupe> Find(Func<Groupe, bool> predicate)
        {
            var data = Groupedata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Groupedata.Find(x => true);
        }
        public void Remove(Groupe groupe)
        {
            Groupedata.Remove(groupe);
        }
    }
}
