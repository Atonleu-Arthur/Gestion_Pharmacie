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
    public class UtilisateurBLO 
    {
        private RepositoryFILE<Utilisateur> utilisateurdata;
        public UtilisateurBLO()
        {
            utilisateurdata = new RepositoryFILE<Utilisateur>();
            var count = utilisateurdata.Find(x => true).Count();
            if (count == 0)
            {
              Utilisateur u=
                    new Utilisateur("Admin@yahoo.fr", "admin", "Admin Global Pharma", null, Utilisateur.RoleOption.Administrateur, "697856547", null);
                utilisateurdata.Add(u);
               
            }
        }

        public Utilisateur Login(string userName, string password)
        {
            var users = utilisateurdata.Find(x => x.Compte.ToLower() == userName.ToLower() && x.Mot_de_passe == password  );
             foreach(Utilisateur u in users)
            {
             Utilisateur newuser= new Utilisateur(u.Compte, u.Mot_de_passe, u.Nom_Complet, u.LasConnexionDate, u.Role, u.Telephone, u.Photo);
                if (users != null)
                    u.LasConnexionDate = DateTime.Now;
                newuser = utilisateurdata.Edit(u, newuser);
                    
            }
            return users.FirstOrDefault();
        }

        
        public Utilisateur Edit(Utilisateur oldUser, Utilisateur user)
        {
            oldUser = utilisateurdata.Get(user);
            if (oldUser != null)
            {
                return utilisateurdata.Edit(oldUser, user);
            }
            throw new KeyNotFoundException(user?.Compte);
        }

        public  void Add(Utilisateur utilisateur)
        {
            utilisateurdata.Add(utilisateur);
        }

        public IEnumerable<Utilisateur> Find(Func<Utilisateur, bool> predicate)
        {
            var data = utilisateurdata.Find(predicate);
           
            return data;
        }
        public void GETALL()
        {
           utilisateurdata.Find(x => true);
        }
        public void Remove(Utilisateur user)
        {
            utilisateurdata.Remove(user);
        }
    }
}
