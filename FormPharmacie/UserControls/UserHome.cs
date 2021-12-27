using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace FormPharmacie.UserControls
{
    public partial class UserHome : UserControl
    {
        bool affiche;
        public UserHome()
        {
            InitializeComponent();
            affiche = true;
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        private void LoardChart()
        {
           

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void moveSidePanel(Control btn)
        {

            
            panelSide.Width = btn.Width;
        }

        private void Btnfichier_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnfichier);
        }

        private void BtnAchat_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnAchat);
        }

        private void BtnVentes_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnVentes);
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            //moveSidePanel(BtnStocks);
        }

        private void SubMenu_Click(object sender, EventArgs e)
        {
            //moveSidePanel(BtnAccueil);
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void Btnfichier_Click_1(object sender, EventArgs e)
        {
            if (affiche )
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

        private void GunaButton17_Click(object sender, EventArgs e)
        {

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

        private void BtnStocks_Click_1(object sender, EventArgs e)
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

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }
        private void AddControlTopanel(Control c)
        {
            //c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
     

        private void GunaButton1_Click_1(object sender, EventArgs e)
        {
            UserControlVente c = new UserControlVente();
            AddControlTopanel(c);
        }

        private void GunaElipsePanel8_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            UserControlVente c = new UserControlVente();
            AddControlTopanel(c);
        }
    }
}
