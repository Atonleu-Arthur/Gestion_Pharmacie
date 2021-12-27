using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Personne
    {
      

        public int Id_personne { get; set; }
        public string Nom_Complet { get; set; }
      
        public int Age { get; set; }
        public char Sexe { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Personne(string nom_Complet, string telephone)
        {
            Nom_Complet = nom_Complet;
            Telephone = telephone;
        }
        public Personne(string nom_complet)
        {
            Nom_Complet = nom_complet;
        }

        public Personne()
        {
        }

      
    }
}
