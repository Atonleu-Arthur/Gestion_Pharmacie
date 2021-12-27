using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Rayon
    {
        public int Id_rayon { get; set; }
        public string Nom_rayon { get; set; }
        public string Groupe  { get; set; }

        public Rayon(string nom_rayon,string groupe)
        {
            Nom_rayon = nom_rayon;
            Groupe = groupe;
        }

        public Rayon(string nom_rayon)
        {
            Nom_rayon = nom_rayon;
        }

        public override string ToString()
        {
            return Nom_rayon;

        }

      
     

        public override bool Equals(object obj)
        {
            return obj is Rayon rayon &&
                   Id_rayon == rayon.Id_rayon;
        }

        public override int GetHashCode()
        {
            return -201508782 + Id_rayon.GetHashCode();
        }
    }
}
