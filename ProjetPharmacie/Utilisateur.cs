using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
    [Serializable]
  
    public class Utilisateur : Personne
    {
        public enum RoleOption
        {
            Administrateur,
            Employee
        }

        public string Id_utilisateur { get; set; }
        public string Compte { get; set; }
        public string Mot_de_passe { get; set; }
        public DateTime? LasConnexionDate { get; set; }
        public string Photo { get; set; }
        public RoleOption Role  { get; set; }

       
        public Utilisateur(string compte, string mot_de_passe, string nom_Complet, DateTime? lasConnexionDate, RoleOption role,  string telephone, string photo) : base(nom_Complet, telephone)
        {
            Compte = compte;
            Mot_de_passe = mot_de_passe;
            Photo = photo;
            Role = role;
            LasConnexionDate = lasConnexionDate;
          
        }
        public Utilisateur(string compte) :base()
        {
            Compte = compte;
        }

      

        public Utilisateur(string id_utilisateur, string compte, string mot_de_passe, DateTime lasConnexionDate, string photo)
        {
            Id_utilisateur = id_utilisateur;
            Compte = compte;
            Mot_de_passe = mot_de_passe;
            LasConnexionDate = lasConnexionDate;
            Photo = photo;
        }
        public Utilisateur(Utilisateur user) 
        {
            Id_utilisateur = user?.Id_utilisateur;
            Compte = user?.Compte;
            Mot_de_passe = user?.Mot_de_passe;
            LasConnexionDate = user?.LasConnexionDate;
            Role = user?.Role ?? RoleOption.Employee;
            Nom_Complet = user?.Nom_Complet;
            Telephone = user?.Telephone;

           
        
        }
 
        public override bool Equals(object obj)
        {
            return( obj as Utilisateur)?.Compte.Equals(this.Compte)?? false;
        }

        public override int GetHashCode()
        {
            return this.Compte?.GetHashCode() ?? 0;
        }
        public override string ToString()
        {
            return this.Nom_Complet;
        }
    }
}
