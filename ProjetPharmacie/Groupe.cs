using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Groupe  
    {
       
        public string Nom_groupe { get; set; }
        public Rayon Rayon { get; set; }

        public Groupe()
        {
        }

        public Groupe(string nom_groupe) 
        {
            Nom_groupe = nom_groupe;           
        }

        public override bool Equals(object obj)
        {
            return (obj as Groupe)?.Nom_groupe.Equals(this.Nom_groupe) ?? false;

        }

        public override int GetHashCode()
        {
            return Nom_groupe.GetHashCode();
        }
        public override string ToString()
        {
            return Nom_groupe;
        }
    }
}
