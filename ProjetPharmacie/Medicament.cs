using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Medicament 
    {
      

        public string Nom_medicament { get; set; }
        private static  int count=0;
        //public double Quantite { get; set; }
        public string DCI { get; set; }
        public string Forme { get; set; }
        public string Conditionnement { get; set; }
        public string Dosage { get; set; }
        public  int Id_Medicament { get; set; }
        public Groupe Groupe  { get; set; }
        public string Remarque { get; set; }
        public Rayon Rayon  { get; set; }

        //public string Conditionnement { get; set; }

        public Medicament(int id_medicament, string nom_medicament, string forme_pharmaceutique) /* string nom_groupe, string nom_rayon) :base (nom_groupe,  nom_rayon)*/
        {
            Nom_medicament = nom_medicament;
            Remarque =forme_pharmaceutique;
            id_medicament = Id_Medicament;
            this.Id_Medicament = count++;
            //id_medicament = this.Id_Medicament;
            //Conditionnement = conditionnement;
        }

        public Medicament(Groupe groupe,Rayon rayon ,string nom_medicament, string dCI, string dosage, string forme, string conditionnement)
        {
            Id_Medicament = count++;
            DCI = dCI;
            Forme = forme;
            Rayon = rayon;
            Groupe = groupe;
            Conditionnement = conditionnement;
            Dosage = dosage;
            Nom_medicament = nom_medicament;


        }

        public Medicament(string nom_medicament,Groupe groupe)
        {
            Nom_medicament = nom_medicament;
            Groupe = groupe;
        }

        public Medicament(string nom_medicament)
        {
            Nom_medicament = nom_medicament;
        }
        public Medicament(string nom_medicament, string dci)
        {
            Nom_medicament = nom_medicament;
            DCI = dci;
        }
        public Medicament()
        {
        }

        public override int GetHashCode()
        {
            return Id_Medicament.GetHashCode() ;

        }

        public override bool Equals(object obj)
        {
            return
                (obj as Medicament)?.Id_Medicament.Equals(this.Id_Medicament) ?? false;
                 
        }
    }
}
