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
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace ProjetPharmacie.Multicouche.BLL
{
    public class ProduitBLO
    {
        private RepositoryFILE<Produit> produitdata;
        public ProduitBLO()
        {
            produitdata = new RepositoryFILE<Produit>();

            var count = produitdata.Find(x => true).Count();
            if (count == 0)
            {
                List<Produit> produits = new List<Produit>
                {
                    //new Produit(Produit.Famille.Medicament, "DEPAKINE CHRONO 500 mg , Comprimé pelliculé",00,5470,20,200),
                    //new Produit(Produit.Famille.Medicament, "D-RUBICIN 10mg/10 ml Poudre pour usage parentéral",00,4780,20,100),
                    //new Produit(Produit.Famille.Medicament, "DAFLON 500 mg , Comprimé pelliculé",00,3500,20,50),
                    //new Produit("DACRYOBORALINE, collyre",00),
                };
                foreach (Produit u in produits)
                {
                    produitdata.Add(u);
                }
            }

        }

        public Produit Edit(Produit oldProduct, Produit newProduct)
        {
            oldProduct = produitdata.Get(newProduct);
            if (oldProduct != null)
            {
                return produitdata.Edit(oldProduct, newProduct);
            }
            throw new KeyNotFoundException(newProduct?.Code_barre.ToString());
        }

 


    public void Add(Produit groupe)
        {
            produitdata.Add(groupe);
        }
        public IEnumerable<Produit> Find(Func<Produit, bool> predicate)
        {
            var data = produitdata.Find(predicate);

            return data;
        }
        public void GETALL()
        {
            produitdata.Find(x => true);
        }
        public void Vente()
        {

        }
       
    }

}
