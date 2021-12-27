using ProjetPharmacie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPharmacie
{
   public  class Stock 
    {
        public int Stock_actuel { get; set; }
        public DateTime Date_entre { get; set; }

        //public Stock(int stock_initial, int stock_actuel, DateTime date_entre,string nom,double prixV, int qtes ) :base(prixV,qtes,nom)
        //{
        //    Stock_actuel = stock_actuel;
        //    Date_entre = date_entre;
        //}

      
    }
}
