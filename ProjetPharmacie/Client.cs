using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie.BO
{
    [Serializable]
    public class Client : Personne
    {
        public int Id_Client { get; set; }
        private static int Count = 0;

        public Client(string nom_complet) : base (nom_complet) 
        {
            Id_Client = Count++;
            Nom_Complet = nom_complet;
        }

        public override bool Equals(object obj)
        {
            return (obj as Client)?.Nom_Complet.Equals(this.Nom_Complet) ?? false;

        }

        public override int GetHashCode()
        {
            return  Id_Client.GetHashCode();
        }
        public override string ToString()
        {
            return Nom_Complet.ToString();
        }

    }
}
