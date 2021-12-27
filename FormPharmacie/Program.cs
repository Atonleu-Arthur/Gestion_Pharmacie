using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Splash_Screen demarrage = new Splash_Screen();
            //demarrage.Show();
            new Splash_Screen().Show();
            Application.Run();
        }
        public static bool IsIndesignMode()
        {
            if(Application.ExecutablePath.IndexOf("devenv.exe",StringComparison.OrdinalIgnoreCase)>-1)
            {
                return true;
            }
            return false;
        }
    }
}
