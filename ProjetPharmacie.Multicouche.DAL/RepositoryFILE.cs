using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProjetPharmacie.BO;
using System.Collections;
namespace ProjetPharmacie.Multicouche.DAL
{
    public class RepositoryFILE<T>
    {

        private readonly string photoPath = Path.Combine(Directory.GetCurrentDirectory(), "Images");
        private BinaryFormatter binaryFormatter = null;
        private FileInfo File;
        private string FILEPATH = null;
        private List<T> liste;
        private  T newitem ;


        public RepositoryFILE()

        {
            binaryFormatter = new BinaryFormatter();
            FILEPATH = $"datas/{typeof(T).Name}.data";
            File = new FileInfo(FILEPATH);

            if (!File.Directory.Exists)
                File.Directory.Create();
            if (!File.Exists)
                File.Create().Close();
            File.Refresh();

            if (File.Length > 0)
            {
                using (FileStream fs = File.OpenRead())
                {
                    liste = (List<T>)binaryFormatter.Deserialize(fs);
                }
            }
            if (liste == null)
                liste = new List<T>();
        }
        public void Add(T item)
        {
           
            if (item == null)
            {
                throw new ArgumentNullException("object null");
             
            }

            if (liste.Contains(item))
            {
              
                throw new DuplicateWaitObjectException(item.ToString() + "Existe deja dans la base de donnees Ajout impossible");
                
            }
            else
                liste.Add(item);

            using (FileStream fs = File.OpenWrite())
            {
                binaryFormatter.Serialize(fs, liste);
            }

        }
      
        public void Remove(T item)
        {
            List<T> liste4 = null;
            if (File.Length > 0)
            {
                using (FileStream fs = File.OpenRead())
                {
                    liste4 = (List<T>)binaryFormatter.Deserialize(fs);
                }
            }
            if (liste4 == null)
                liste4 = new List<T>();

            if (item == null)
                throw new ArgumentNullException("object null");

            if (!liste4.Contains(item))
                throw new Exception(item.ToString() + " pas dans la liste ");
            else
                liste4.Remove(item);

            using (FileStream fs = File.OpenWrite())
            {
                binaryFormatter.Serialize(fs, liste4);
            }
        }

        public T Edit(T oldT, T newT)
        {
            List<T> liste3 = null;
            if (File.Length > 0)
            {
                using (FileStream fs = File.OpenRead())
                {
                    liste3 = (List<T>)binaryFormatter.Deserialize(fs);
                }
            }
            if (liste3 == null)
                liste3 = new List<T>();

            int oldIndex = liste3.IndexOf(oldT);
            int newIndex = liste3.IndexOf(newT);

            if (oldT == null || newT == null)
                throw new ArgumentNullException("un des elements est null");

            if (oldIndex > -1 && (oldIndex == newIndex || newIndex == -1))
            {
                liste3[oldIndex] = newT;

                using (FileStream fs = File.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, liste3);
                }
            }
            else if (oldIndex == -1)
            {
                throw new KeyNotFoundException(oldT.ToString() + " pas dans la liste");
            }
            else if (newIndex != -1 && oldIndex != newIndex)
            {
                throw new DuplicateWaitObjectException(newT.ToString() + " existe deja");
            }
            return newT;
        }
        

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            List<T> l = new List<T>();
            foreach (T item in liste)
            {
                if (predicate(item)) // si u correcpond a la fonction predicate on l'ajoute dans la liste
                    l.Add((item));
            }
            return l;
        }
        public T Get(T t)
        {
           return liste.FirstOrDefault(x => x.ToString() == t.ToString());
        }


        public int Count => liste.Count();
        
    
    }
}