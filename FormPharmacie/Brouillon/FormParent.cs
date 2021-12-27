using FormPharmacie.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie
{
    public partial class FormParent : Form
    {
        bool affiche;
        public FormParent()
        {
            InitializeComponent();
         
            affiche = true;
        }

        private void Btnfichier_Click(object sender, EventArgs e)
        {

            if (affiche)
            {
                panelMenuFichier.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuFichier.Visible = false;
                affiche = true;
            }

        }

        private void BtnAchat_Click(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuAchat.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuAchat.Visible = false;
                affiche = true;
            }
        }

        private void GunaButton8_Click(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuVente.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuVente.Visible = false;
                affiche = true;
            }
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuStock.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuStock.Visible = false;
                affiche = true;
            }
        }

        private void GunaButton7_Click(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuTresorie.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuTresorie.Visible = false;
                affiche = true;
            }


        }
        private void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(c);
        }
      

        private void GunaButton37_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GunaButton36_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
       
        private void GunaButton1_Click_1(object sender, EventArgs e)
        {
            UserControlVente c = new UserControlVente();
            AddControlTopanel(c);
        }

        private void PanelMenuTresorie_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton36_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btnfichier_Click_2(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuFichier.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuFichier.Visible = false;
                affiche = true;
            }
        }

        private void BtnAchat_Click_1(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuAchat.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuAchat.Visible = false;
                affiche = true;
            }
        }

        private void GunaButton8_Click_2(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuVente.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuVente.Visible = false;
                affiche = true;
            }
        }

        private void BtnStocks_Click_2(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuStock.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuStock.Visible = false;
                affiche = true;
            }
        }

        private void GunaButton7_Click_2(object sender, EventArgs e)
        {
            if (affiche)
            {
                panelMenuTresorie.Visible = true;
                affiche = false;
            }

            else
            {
                panelMenuTresorie.Visible = false;
                affiche = true;
            }
        }

        private void GunaButton1_Click_2(object sender, EventArgs e)
        {
            //panelControl.Visible = false;
            
            //UserControlComptoir c = new UserControlComptoir();
            //AddControlTopanel(c);
           
        }

        private void GunaButton37_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void GunaButton1_Click_3(object sender, EventArgs e)
        {
            //panelChange.Visible = false;
            UserControlVente c = new UserControlVente();
            AddControlTopanel(c);
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            //panelControl.Controls.Clear();
            //panelChange.Visible = true;
        }

        private void GunaButton1_Click_4(object sender, EventArgs e)
        {
            //panelChange.Visible = false;
            UserControlVente c = new UserControlVente();
            AddControlTopanel(c);

        }

        

        private void FormParent_Load(object sender, EventArgs e)
        {

        }

        private void GunaButton1_Click_6(object sender, EventArgs e)
        {
            //UserControlComptoir c = new UserControlComptoir();
            //AddControlTopanel(c);
            //PanelComptoir.Visible = false;
            //PanelCaisse.Visible = false;
            //PanelStock.Visible = false;
            //PanelUtilisateur.Visible = false;
            //PanelQuitter.Visible = false;
            //PanelTransaction.Visible = false;
            //PanelInfos.Visible = false;
            //txtBienvenu.Visible = false;
            //txtNom.Visible = false;
            //PanelVente.Visible = false;
            //PanelAchat.Visible = false;
            panelCentre.Visible = false;
            UserControlVente c = new UserControlVente();
                panelCentre.Controls.Add(c);
            
            
             
            

        }

        private void GunaButton38_Click(object sender, EventArgs e)
        {
            //panelCentre.Controls.Clear();
            
           
           

        }

        private void GunaButton38_Click_1(object sender, EventArgs e)
        {
            //PanelComptoir.Visible = true;
            //PanelCaisse.Visible = true;
            //PanelStock.Visible = true;
            //PanelUtilisateur.Visible = true;
            //PanelQuitter.Visible = true;
            //PanelTransaction.Visible = true;
            //PanelInfos.Visible = true;
            //txtBienvenu.Visible = true;
            //txtNom.Visible = true;
            //PanelVente.Visible = true;
            //PanelAchat.Visible = true;
        }

      
        private void GunaButton38_Click_2(object sender, EventArgs e)
        {
            panelCentre.Visible = true;
            panelForm.Visible = false;
            panelCentre2.Visible = true;
          
        }

        private void GunaButton1_Click_7(object sender, EventArgs e)
        {
            //panelCentre.Visible = true;
            //panelCentre2.Visible = false;
            UserControlVente c = new UserControlVente();
            panelForm.Controls.Add(c);
        }
    }
}
