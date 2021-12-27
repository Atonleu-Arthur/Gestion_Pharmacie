using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Fournisseur
    {
        private static int count = 0;
        public int Id_fournisseur { get; set; }
        public string Nom_fournisseur { get; set; }
        public string Adresse { get; set; }
        public double Telephone { get; set; }
        public string Email { get; set; }

        public Fournisseur(string nom_fournisseur, string adresse, double telephone)
        {
            Id_fournisseur = count++;
            Nom_fournisseur = nom_fournisseur;
            Adresse = adresse;
            Telephone = telephone;
        }

        public override bool Equals(object obj)
        {
            return (obj as Fournisseur)?.Adresse.Equals(this.Adresse) ?? false;

        }

        public override int GetHashCode()
        {
            return Nom_fournisseur.GetHashCode();
        }
        public override string ToString()
        {
            return Nom_fournisseur;
        }
    }
}
