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
    public class MedicamentBLL
    {
        private RepositoryFILE<Medicament> Medicamentdata;
        public List<Groupe> liste;
        private Medicament Id  { get; set; }
        public MedicamentBLL()
        {
            Medicamentdata = new RepositoryFILE<Medicament>();           
           
            var count = Medicamentdata.Find(x => true).Count();
            if (count == 0)
            {

               

                List<Medicament> medicaments = new List<Medicament>
                {
                

                    new Medicament(LoadataUser(x=>true,0),new Rayon("Rayon N°A"),"ABILIFY ", "Aripiprazole","10mg","Comprimés","B/20"),

                     new Medicament(LoadataUser(x=>true,0),new Rayon("Rayon N°A"),"A.V.T. ", "ACIDE ACETYLSALICYLIQUE","600mg","Suppositoire", "B/10ml")
                     //"L'acide acétylsalicylique ou" +
                     //" acide spirique, plus connu sous le nom commercial d'aspirine, est la substance active de nombreux" +
                     //" médicaments aux propriétés antalgiques, " +
                     //"antipyrétiques et anti-inflammatoires. Il est aussi utilisé comme" +
                     //" antiagrégant plaquettaire. Il s'agit d'un anti-inflammatoire non stéroïdien."),

                 };
                foreach(Medicament u in medicaments)
                {
                    Medicamentdata.Add(u);
                }

            }
        }
        public Groupe LoadataUser(Func<Groupe, bool> predicat, int index)
        {

            GroupeBLO groupes = new GroupeBLO();
            IEnumerable<Groupe> utl = groupes.Find(predicat);
            if (utl != null)
            {
                liste = new List<Groupe>(utl);

            }

            return liste[index];

        }
        public Medicament Edit(Medicament oldMedoc, Medicament newMedocs)
        {
            oldMedoc = Medicamentdata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Medicamentdata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_medicament);
        }

        public int recupereId(Func<Medicament, bool> predicat, Medicament vente)
        {
            MedicamentBLL achats = new MedicamentBLL();
            IEnumerable<Medicament> achats1 = achats.Find(predicat);
            foreach (Medicament a in achats1)
            {
                if (vente.Id_Medicament == a.Id_Medicament)
                {
                    vente.Id_Medicament = vente.Id_Medicament + 1;
                }
            }
            return 0;
        }
        public void Add(Medicament Medicament)
        {
            Medicamentdata.Add(Medicament);
        }

        public IEnumerable<Medicament> Find(Func<Medicament, bool> predicate)
        {
            var data = Medicamentdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Medicamentdata.Find(x => true);
        }
        public void Remove(Medicament user)
        {
            Medicamentdata.Remove(user);
        }
    }
}
