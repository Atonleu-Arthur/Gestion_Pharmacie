//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace ProjetPharmacie.Multicouche.DAL
//{
//    public class UtilisateurDAO : IDAL<Utilisateur>
//    {
//        private static List<Utilisateur> users = null;

//        public UtilisateurDAO()
//        {
//            if (users == null)
//            {
//                users = new List<Utilisateur>
//                {
//                    new Utilisateur("admin", "admin" , null,"Administrateur"),
                    
//                };
//            }
//        }
//        public void Add(Utilisateur user)
//        {
//            if (users == null)
//                throw new ArgumentNullException("user");
//            if (users.Contains(user))
//                throw new DuplicateWaitObjectException();

//            users.Add(user);
//        }

     

//        public IEnumerable<Utilisateur> Find(Func<Utilisateur, bool> predicate)
//        {
//            if (predicate == null)
//                throw new ArgumentNullException("predicate");
//            return users.Where(predicate).ToArray();
//        }

//        public Utilisateur Get(Utilisateur user)
//        {
//            if (user == null)
//                throw new ArgumentNullException("user");
//            int index = users.IndexOf(user);
//            if (index >= 0)
//                return users[index];
//            return null;
//        }

//        public void Remove(Utilisateur user)
//        {
//            if (user == null)
//                throw new ArgumentNullException("user");
//            if (Get(user) != null)
//                users.Remove(user);
//        }

//        public void Set(Utilisateur user)
//        {
//            if (user == null)
//                throw new ArgumentNullException("user");
//            int index = users.IndexOf(user);
//            if (index >= 0)
//                users[index] = user;
//        }
       
//    }
//}
