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
    public class ClientBLO
    {
        private RepositoryFILE<Client> Clientdata;
        public ClientBLO()
        {
            Clientdata = new RepositoryFILE<Client>();

            var count = Clientdata.Find(x => true).Count();
            if (count == 0)
            {
                Client client = new Client("Anonyme");
                Clientdata.Add(client);
            }

        }
        public Client Edit(Client oldMedoc, Client newMedocs)
        {
            oldMedoc = Clientdata.Get(newMedocs);
            if (oldMedoc != null)
            {
                return Clientdata.Edit(oldMedoc, newMedocs);
            }
            throw new KeyNotFoundException(newMedocs?.Nom_Complet);
        }
        public int recupereId(Func<Client, bool> predicat, Client client)
        {
            ClientBLO achats = new ClientBLO();
            IEnumerable<Client> achats1 = achats.Find(predicat);
            foreach (Client a in achats1)
            {
                if (client.Id_Client == a.Id_Client)
                {
                    client.Id_Client = client.Id_Client + 1;
                }
            }
            return 0;
        }
        public void Add(Client client)
        {
            recupereId(x => true, client);
            Clientdata.Add(client);
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            var data = Clientdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            Clientdata.Find(x => true);
        }
        public void Remove(Client client)
        {
            Clientdata.Remove(client);
        }
    }
}
