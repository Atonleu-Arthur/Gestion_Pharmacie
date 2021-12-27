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
    public class FournisseurBLO
    {
        private RepositoryFILE<Fournisseur> Fournisseurdata;
        public FournisseurBLO()
        {
            Fournisseurdata = new RepositoryFILE<Fournisseur>();

            var count = Fournisseurdata.Find(x => true).Count();
            if (count == 0)
            {
                List<Fournisseur> fournisseurs = new List<Fournisseur>
                {
                    new Fournisseur( "MDL PHARMA", " BP 2014 Douala-Bonanjo ", +237678158963),
                    new Fournisseur("BIO MEDICAL", " BP 123 France-Paris Rue des Gautiers  ", +33347856625),
            };
                foreach(Fournisseur u in fournisseurs)
                {
                    Fournisseurdata.Add(u);
                }

            }
        }
        public Fournisseur Edit(Fournisseur oldMedoc, Fournisseur newMedocs)
        {
            oldMedoc = Fournisseurdata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Fournisseurdata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_fournisseur);
        }
        public int recupereId(Func<Fournisseur, bool> predicat, Fournisseur vente)
        {
            FournisseurBLO achats = new FournisseurBLO();
            IEnumerable<Fournisseur> achats1 = achats.Find(predicat);
            foreach (Fournisseur a in achats1)
            {
                if (vente.Id_fournisseur == a.Id_fournisseur)
                {
                    vente.Id_fournisseur = vente.Id_fournisseur + 1;
                }
            }
            return 0;
        }
        public void Add(Fournisseur fournisseur)
        {
            Fournisseurdata.Add(fournisseur);
        }

        public IEnumerable<Fournisseur> Find(Func<Fournisseur, bool> predicate)
        {
            var data = Fournisseurdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Fournisseurdata.Find(x => true);
        }
        public void Remove(Fournisseur fournisseur)
        {
            Fournisseurdata.Remove(fournisseur);
        }
    }
}
