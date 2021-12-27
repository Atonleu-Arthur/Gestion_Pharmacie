using FormPharmacie.UserControls;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;
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
    public partial class FormDashboardPharmacie : Form
    {
        int panelwith;
        bool isCollapsed;
        public FormDashboardPharmacie()
        {
            InitializeComponent();
            timerTimer.Start();
            LoadataAchat(x => true);
            panelwith = panelleft.Width;
            isCollapsed = false;
            f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;
            PanelSideMenu.Visible = true;
            //UserHome user = new UserHome();
            //AddControlTopanel(user);
        }

        private void FormDashboardPharmacie_Load(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if(panelleft.Width>=panelwith)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if(panelleft.Width<=44)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
        private void moveSidePanel(Control btn)
        {

            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void moveSidePanel2(Control btn)
        {

        }
        private void moveSidePanel3(Control btn)
        {

         
        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }

  

        private void BtnSideVendre_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnEnregistrement_Click(object sender, EventArgs e)
        {
            
        }

     

        private void BtnParametres_Click(object sender, EventArgs e)
        {
        }

        private void TimerTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label.Text = dt.ToString("HH-MM-ss");
        }

        public void LoadataAchat(Func<Achat, bool> predicat)
        {
            int rupture = 0;
            int peremtion = 0;
            AchatBLO historiques = new AchatBLO();
            IEnumerable<Achat> listeA = historiques.Find(predicat);

            foreach(Achat a in listeA)
            {
                if (a.Quantite_stock <= 0)
                    rupture ++;
                if (Convert.ToDateTime(a.Date_Expiration) < DateTime.Now)
                    peremtion ++;
            }

            stockrup.Text = rupture.ToString();
            perime.Text = peremtion.ToString();
        }
        private void PanelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelcentre1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVente_Click(object sender, EventArgs e)
        {
            PanelSideMenu.Visible = false;
            panelcentre1.Visible = false;
            UserControlVente user = new UserControlVente();
            AddControlTopanel(user);
            
        }

 

        private void Btnfichiers_Click(object sender, EventArgs e)
        {
            panelSide.Visible = false;
            panelcentre1.Visible = false;
            PanelSideMenu.Visible = false;
            MoveSideMenu24.Visible = false;
            MoveSidePanel23.Visible = true;
            MoveSidePanel25.Visible = false;
            MoveSidePanel26.Visible = false;
            UserControlFichier user = new UserControlFichier();
            AddControlTopanel(user);
            
        }

      

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            panelcentre1.Visible = false;
            panelSide.Visible = false;
            MoveSidePanel26.Visible = true;
            PanelSideMenu.Visible = false;
            UserControlHistoriqueAcht user = new UserControlHistoriqueAcht();
            AddControlTopanel(user);
            btnHome.Visible = false;
            //Btn1.Visible = false;
            //Btn2.Visible = false;
            //Btn3.Visible = false;
            f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;


        }

   

      
       

        private void BtnStock_Click(object sender, EventArgs e)
        {
            panelcentre1.Visible = false;
            panelSide.Visible = false;
            btnHome.Visible = false;
            MoveSideMenu24.Visible = true;
            PanelSideMenu.Visible = false;

            //Btn1.Visible = false;
            //Btn2.Visible = false;
            //Btn3.Visible = false;
            f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;

            UserControlStockSG user = new UserControlStockSG();
            AddControlTopanel(user);
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            PanelStock.Visible = true;
            panelSide.Visible = false;

            panelcentre1.Visible = false;
            panelSide.Visible = false;
            btnHome.Visible = false;
            MoveSidePanel23.Visible = false;
            MoveSidePanel25.Visible = false;
            MoveSidePanel26.Visible = false;
            MoveSideMenu24.Visible = true;
            PanelSideMenu.Visible = false;
            UserControlStockP user = new UserControlStockP();
            AddControlTopanel(user);
        }
  

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            panelSide.Visible = true;

            moveSidePanel(BtnHistV);

            PanelSideMenu.Visible = false;
            panelcentre1.Visible = false;
            UserControlHistoriqueVente user = new UserControlHistoriqueVente();
            AddControlTopanel(user);
        }

       

        private void GunaButton1_Click_1(object sender, EventArgs e)
        {
            panelcentre1.Visible = true;
            PanelSideMenu.Visible = false;
            btnHome.Visible = true;
            panelSide.Visible = false;
            panelcentre1.BringToFront();
            panelCenter.Controls.Clear();
            MoveSidePanel23.Visible = false;
            MoveSidePanel25.Visible = false;
            MoveSidePanel26.Visible = false;
            MoveSideMenu24.Visible = false;
            PanelSideMenu.Visible = true;

        }

        private void PictureProfil_Click(object sender, EventArgs e)
        {

        }

        private void Panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F2_Paint(object sender, PaintEventArgs e)
        {

        }


    

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelstatut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statut_Click(object sender, EventArgs e)
        {

        }

        private void PanelComptoir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelInfos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton35_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void PanelVente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelAchat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHautMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelSide2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNom_Click(object sender, EventArgs e)
        {

        }

        private void PanelCentre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void BtnTresorie_Click(object sender, EventArgs e)
        {
            panelcentre1.Visible = false;
            panelSide.Visible = false;

            PanelSideMenu.Visible = true;
            MoveSidePanel23.Visible = false;
            MoveSidePanel25.Visible = true;
            MoveSidePanel26.Visible = false;
            MoveSideMenu24.Visible = false;
            PanelSideMenu.Visible = false;

            UserControlTresorie user = new UserControlTresorie();
            AddControlTopanel(user);
        }

        private void BtnAchat_Click(object sender, EventArgs e)
        {
            panelcentre1.Visible = false;
            panelSide.Visible = false;

            MoveSidePanel23.Visible = false;
            MoveSidePanel25.Visible = false;
            MoveSidePanel26.Visible = true;
            MoveSideMenu24.Visible = false;
            PanelSideMenu.Visible = false;

            UserControlAchatp user = new UserControlAchatp();
            AddControlTopanel(user);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            moveSidePanel(BtnParametre);
            panelcentre1.Visible = false;
            PanelSideMenu.Visible = false;
            PanelSideMenu.Visible = false;
            moveSidePanel(BtnParametre);

            UserControlParametre user = new UserControlParametre();
            AddControlTopanel(user);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            btnHome.BackColor=Color.FromArgb(192, 192, 255);


        }

        private void GunaButton10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void BtnParametre_Click(object sender, EventArgs e)
        {
            moveSidePanel(BtnParametre);
            panelcentre1.Visible = false;
            PanelSideMenu.Visible = true;

            UserControlParametre user = new UserControlParametre();
            AddControlTopanel(user);
        }

        private void BtnHistV_Click(object sender, EventArgs e)
        {
            moveSidePanel(BtnHistV);
            panelcentre1.Visible = false;

            UserControlHistoriqueVente user = new UserControlHistoriqueVente();
            AddControlTopanel(user);
        }

        private void BtnHistAchat_Click(object sender, EventArgs e)
        {
            moveSidePanel(BtnHistAchat);
            panelcentre1.Visible = false;
            PanelSideMenu.Visible = true;

            UserControlHistoriqueAcht user = new UserControlHistoriqueAcht();
            AddControlTopanel(user);
        }
    }
}
