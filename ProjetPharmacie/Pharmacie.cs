using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
  public  class Pharmacie
    {
        public string Nom_pharmacie { get; set; }
        public string Adresse { get; set; }

        public string Nom_gerant  { get; set; }
        public string Logo  { get; set; }
        public double Contact { get; set; }

        public Pharmacie(string nom_pharmacie, string adresse, string nom_gerant, string logo, double contact)
        {
            Nom_pharmacie = nom_pharmacie;
            Adresse = adresse;
            Nom_gerant = nom_gerant;
            Logo = logo;
            Contact = contact;
        }

        public override bool Equals(object obj)
        {
            return obj is Pharmacie pharmacie &&
                   Nom_pharmacie == pharmacie.Nom_pharmacie;
        }

        public override int GetHashCode()
        {
            return 1929375842 + EqualityComparer<string>.Default.GetHashCode(Nom_pharmacie);
        }
    }
}
