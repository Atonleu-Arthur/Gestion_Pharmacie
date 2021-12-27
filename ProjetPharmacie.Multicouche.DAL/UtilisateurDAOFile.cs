//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.IO;
//using ProjetPharmacie.BO;
//using System.Collections;

//namespace ProjetPharmacie.Multicouche.DAL
//{
//    public class UtilisateurDAOFile : IList<Utilisateur>
//    {
//        private List<Utilisateur> utilisateurs = null;
//        private readonly string photoPath = Path.Combine(Directory.GetCurrentDirectory(), "Images");
//        private readonly string dataPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");
//        private string DataFile;



//        public UtilisateurDAOFile()
//        {
//            DataFile = Path.Combine(dataPath, "Utilisateur.data");

//            DirectoryInfo di = new DirectoryInfo(photoPath);
//            if (!di.Exists)
//            {
//                di.Create();
//                di.Refresh();
//            }
//            DirectoryInfo di2 = new DirectoryInfo(dataPath);
//            if (!di2.Exists)
//            {
//                di2.Create();
//                di2.Refresh();
//            }

//            FileInfo fi = new FileInfo(DataFile);
//            if (!fi.Exists)
//            {
//                fi.Create().Close();
//                fi.Refresh();
//            }
//            if (utilisateurs == null)
//                utilisateurs = new List<Utilisateur>();

//            if (fi.Length > 0)
//            {
//                using (StreamReader sr = new StreamReader(fi.FullName))
//                {
//                    string line = null;
//                    while ((line = sr.ReadLine()) != null)
//                    {
//                        utilisateurs.Add(Deserialize(line));
//                    }
//                }
//            }
//            else
//            {
//                Utilisateur utilisateur =
//                new Utilisateur("Admin@yahoo.fr", "admin", "Admin Glbal Pharma", null, Utilisateur.RoleOption.Administrateur, "0100", null);
//                utilisateurs.Add(utilisateur);
//                using (StreamWriter streamWriter = new StreamWriter(fi.FullName))
//                {
//                    foreach (Utilisateur u in utilisateurs)
//                    {
//                        streamWriter.WriteLine(Serialize(u));
//                    }
//                }

//            }




//        }

//        public void Check(Utilisateur utilisateur) // effectue une verification sur un objet utilisateur 
//        {
//            if (utilisateur == null)
//                throw new ArgumentNullException("utilisateur");
//            if (string.IsNullOrWhiteSpace(utilisateur.Compte))
//                throw new Exception("L'utilisateur ne peut pas etre null ou vide");
//            if (string.IsNullOrWhiteSpace(utilisateur.Mot_de_passe))
//                throw new Exception("Le mot de passe ne peut pas etre null ou vide");
//            if (string.IsNullOrWhiteSpace(utilisateur.Nom_Complet))
//                throw new Exception("le nom complet de l'utilisateur ne peut pas etre null");
//        }
//        private string Serialize(Utilisateur utilisateur)
//        {
//            if (utilisateur != null)
//            {
//                return $"{utilisateur.Compte}|{utilisateur.Mot_de_passe}|{utilisateur.Nom_Complet}|{utilisateur.LasConnexionDate}|{(short)utilisateur.Role}|{utilisateur.Telephone}|{utilisateur.Photo}";
//            }
//            //using (FileStream fs = file.OpenWrite())
//            //{
//            //    formatter.Serialize(fs, utilisateur);
//            //}
//            return null;
//        }

//        private Utilisateur Deserialize(string data)
//        {
//            if (string.IsNullOrEmpty(data))
//            {
//                string[] t = data.Split('|');
//                return new Utilisateur
//                     (
//                     t[0],
//                     t[1],
//                     t[2],
//                     (!string.IsNullOrEmpty(t[3]) ? (DateTime?)DateTime.Parse(t[3]) : null),
//                     (Utilisateur.RoleOption)short.Parse(t[4]),
//                     t[5],
//                     t[6]

//                     );
//            }
//            return null;

//        }
//        public Utilisateur this[int index] // Modification
//        {
//            get => new Utilisateur(utilisateurs[index]);  // renvoie une copie de l'object envoye 
//            set
//            {
//                Check(value);
//                int i = IndexOf(value);
//                if (i >= 0 && index >= 0 && i != index)
//                    throw new Exception("Cette utilisateur " + value.Compte +
//                        "a deja un compte existant ");
//                Utilisateur user = this[index];
//                if (!string.IsNullOrEmpty(user.Photo) && File.Exists(user.Photo))
//                {
//                    File.Delete(user.Photo);
//                }
//                if (!string.IsNullOrEmpty(value.Photo))
//                {
//                    FileInfo fi = new FileInfo(value.Photo);
//                    string photoNewName = Path.Combine(photoPath, Guid.NewGuid().ToString() + Path.GetExtension(value.Photo));
//                    if (fi.Exists)
//                        fi.CopyTo(photoNewName);
//                    value.Photo = photoNewName;//important!!!
//                }

//                //utilisateurs[index] = value;
//                utilisateurs[index] = value;
//                foreach (Utilisateur u in utilisateurs)
//                {
//                    Serialize(u);
//                }
//            }
//        }
//        public Utilisateur this[string compte]
//        {
//            get // permet de modifier un utilisateur juste par le nom de compte
//            {
//                foreach (Utilisateur u in utilisateurs)
//                    if (u.Compte?.Equals(compte, StringComparison.OrdinalIgnoreCase) ??
//                        false)
//                        return new Utilisateur(u);
//                return null;

//            }
//            set // valeur prise en parametre et verification de cette valeur 
//            {

//                Check(value);
//                Utilisateur olduser = this[compte];
//                int i = IndexOf(olduser);
//                int index = IndexOf(value);


//                if (i >= 0 && index >= 0 && i != index)
//                    throw new Exception("Cette utilisateur " + value.Compte +
//                                "a deja un compte existant ");

//                utilisateurs[i] = value;
//                foreach (Utilisateur u in utilisateurs)
//                {
//                    Serialize(u);
//                }


//            }
//        }
//        //  Predicate est une fonction qui prend en parametre un user et retourn un booleen  et c'est lutisateur
//        //  qui fournit cette fonction au moment de l'appel  pour rechercher
//        public IEnumerable<Utilisateur> Find(Func<Utilisateur, bool> predicate) // rechercher un utilisateur peut importe le crite de recherche
//        {
//            List<Utilisateur> l = new List<Utilisateur>();
//            foreach (Utilisateur u in utilisateurs)
//            {
//                if (predicate(u)) // si u correcpond a la fonction predicate on l'ajoute dans la liste
//                    l.Add(new Utilisateur(u));
//            }
//            return l;
//        }

//        public int Count => utilisateurs.Count();

//        public bool IsReadOnly => false;

//        public void Add(Utilisateur item)
//        {
//            Check(item);
//            int i = IndexOf(item);
//            if (i > 0) // si l'index est > 0 alors l'utilisateur exxiste deja sa renvoie un erreur!
//                throw new Exception("Cette utilisateur " + item.Compte +
//                    "a deja un compte existant ");

//            if (!string.IsNullOrEmpty(item.Photo))
//            {
//                FileInfo fi = new FileInfo(item.Photo);
//                string photoNewname = Path.Combine(photoPath, Guid.NewGuid().ToString() + Path.GetExtension(item.Photo));
//                if (fi.Exists)
//                    fi.CopyTo(photoNewname);
//                item.Photo = photoNewname;// tres important

//            }

//            utilisateurs.Add(item);


//            Serialize(item);


//        }

//        public void Clear()
//        {
//            utilisateurs.Clear();
//        }

//        public bool Contains(Utilisateur item)
//        {
//            return utilisateurs.Contains(item);
//        }

//        public void CopyTo(Utilisateur[] array, int arrayIndex)
//        {
//            utilisateurs.CopyTo(array, arrayIndex);
//        }

//        public IEnumerator<Utilisateur> GetEnumerator()
//        {
//            return utilisateurs.GetEnumerator();
//        }

//        public int IndexOf(Utilisateur item)
//        {
//            return utilisateurs.IndexOf(item);
//        }

//        public Utilisateur Login(string compte, string mot_de_passe)
//        {
//            foreach (Utilisateur u in utilisateurs)
//            {
//                if ((u.Compte?.Equals(compte, StringComparison.OrdinalIgnoreCase) ?? false
//                     && (u.Mot_de_passe?.Equals(mot_de_passe) ?? false)))
//                {
//                    Utilisateur us = new Utilisateur(u);
//                    u.LasConnexionDate = DateTime.Now;
//                    using (StreamWriter sw = new StreamWriter(DataFile))
//                    {
//                        foreach (Utilisateur user in utilisateurs)
//                        {
//                            sw.WriteLine(Serialize(user));
//                        }

//                    }



//                    return new Utilisateur(us);
//                    //return new Utilisateur(u);
//                }

//            }
//            throw new Exception("Mot de passe ou compte incorrect!");
//        }
//        public void Insert(int index, Utilisateur item) // ici cest linsertion legerement different de ajouter on insere quelque part tandis que on ajoute a la fin 
//        {
//            Check(item);
//            int i = IndexOf(item);
//            if (i > 0)

//                throw new Exception("Cette utilisateur " + item.Compte +
//                    "a deja un compte existant ");
//            if (!string.IsNullOrEmpty(item.Photo))
//            {
//                FileInfo fi = new FileInfo(item.Photo);
//                string photoNewname = Path.Combine(photoPath, Guid.NewGuid().ToString() + Path.GetExtension(item.Photo));
//                if (fi.Exists)
//                    fi.CopyTo(photoNewname);
//                item.Photo = photoNewname;// tres important

//            }
//            utilisateurs.Insert(index, item);
//            foreach (Utilisateur u in utilisateurs)
//            {
//                Serialize(u);
//            }

//        }
//        public void Insert(string compte, Utilisateur item)
//        {
//            Check(item);
//            int i = IndexOf(item);
//            if (i > 0)
//                throw new Exception("Cette utilisateur " + item.Compte +
//                    "a deja un compte existant ");
//            i = IndexOf(this[compte]);
//            if (!string.IsNullOrEmpty(item.Photo))
//            {
//                FileInfo fi = new FileInfo(item.Photo);
//                string photoNewname = Path.Combine(photoPath, Guid.NewGuid().ToString() + Path.GetExtension(item.Photo));
//                if (fi.Exists)
//                    fi.CopyTo(photoNewname);
//                item.Photo = photoNewname;// tres important

//            }

//            utilisateurs.Insert(i, item);
//            foreach (Utilisateur u in utilisateurs)
//            {
//                Serialize(u);
//            }
//        }
//        public bool Remove(Utilisateur item)
//        {
//            if (!string.IsNullOrEmpty(item.Photo) && File.Exists(item.Photo))
//            {
//                File.Delete(item.Photo);
//            }
//            bool b = utilisateurs.Remove(item);
//            foreach (Utilisateur u in utilisateurs)
//            {
//                Serialize(u);
//            }
//            return b;

//        }

//        public void RemoveAt(int index)
//        {
//            utilisateurs.RemoveAt(index);
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return this.GetEnumerator();
//        }
//        //public void Set( Utilisateur olduser , Utilisateur newuser)
//        //{
//        //    if(olduser!=null && newuser!=null)
//        //    {
//        //        int oldIndex = utilisateurs.IndexOf(olduser);
//        //        int newIndex = utilisateurs.IndexOf(newuser);
//        //        if(newIndex == -1|| newIndex==oldIndex)
//        //        {
//        //            utilisateurs[oldIndex] = newuser;

//        //        }
//        //    }
//        //}
//    }
//}
