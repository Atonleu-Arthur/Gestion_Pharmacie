using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;
using FormPharmacie.UserControls;

namespace FormPharmacie
{
    public partial class FormParentPharmacie : Form
    {
        public FormParentPharmacie()
        {
            
            InitializeComponent();
        }
        
        private void chargement ()
        {
            timer2.Start();

            if (Indicator.Height == 69 && Indicator.Width == 77)
            {
                Indicator.Height = 48;
                Indicator.Width = 60;
            }
            else
            {
                Indicator.Height = 69;
                Indicator.Width = 77;
            }
        }
        private void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }




        private void GunaButton1_Click_2(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;


            UserControlVente user = new UserControlVente();
            AddControlTopanel(user);
            timer2.Stop();

        }

        private void BtnRetour_Click_2(object sender, EventArgs e)
        {
            panelcentre1.Visible = true;
            PanelSide.Visible = false;

            panelcentre1.BringToFront();
            panelCenter.Controls.Clear();
            btnRetour.Visible = false;
        }

        private void GunaButton9_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Indicator_Load(object sender, EventArgs e)
        {
            
          
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void GunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

            if (PanelProfil.Visible == true)
            {
                PanelProfil.Visible = false;
            }
            else
                PanelProfil.Visible = true;
        }

        private void BtnChangeUser_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            this.Dispose();
                f.Show();
        }

        private void GunaButton33_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;
            panelRetour.BackColor = Color.White;


            UserControlParametre user = new UserControlParametre();
            //UserControlGestUtilisateur user = new UserControlGestUtilisateur();
            AddControlTopanel(user);
            timer2.Stop();

            //FormParametre f = new FormParametre();
            //this.Dispose();
            //f.Show();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AboutBox1 f = new AboutBox1();
            //this.IsMdiContainer = true;
            //f.MdiParent = this;
            //f.Show();
        }
        public void appel()
        {
            FormGestUtilisateur f = new FormGestUtilisateur();
            IsMdiContainer = true;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void GunaButton7_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            this.Dispose();
            f.Show();
        }

        private void Statut_Click(object sender, EventArgs e)
        {

        }

        private void PharmacieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;


            UserMedicament user = new UserMedicament();
            AddControlTopanel(user);
            timer2.Stop();
        }

        private void PanelRetour_Paint(object sender, PaintEventArgs e)
        {

        }

        public void BtnVente_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;

          
            UserControlVente user = new UserControlVente();
            AddControlTopanel(user);        
            timer2.Stop();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;


            UserControlClient user = new UserControlClient();
            AddControlTopanel(user);
            timer2.Stop();
        }

        private void FournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;


            UserControlFournisseur user = new UserControlFournisseur();
            AddControlTopanel(user);
            timer2.Stop();
        }

        private void Panelcentre1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVente_Click_1(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;


            UserControlVente user = new UserControlVente();
            AddControlTopanel(user);
            timer2.Stop();
        }
       
        private void Btnfichiers_Click(object sender, EventArgs e)
        {
            chargement();
            panelcentre1.Visible = false;
            btnRetour.Visible = true;
            PanelSide.Visible = true;

            UserControlFichiers user = new UserControlFichiers();
            AddControlTopanel(user);
            timer2.Stop();
        }
    }
}
