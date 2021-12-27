using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPharmacie.UserControls;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.DAL;

namespace FormPharmacie
{
    public partial class FormLogin : Form
    {
        bool closeApp=true;

        public FormLogin()
        {

            //Thread t = new Thread(new ThreadStart(Splash));
            //t.Start();          
            InitializeComponent();
            //string str = string.Empty;
            //for (int i = 0; i < 1000; i++)
            //{
            //    str += i.ToString();
            //}
            //timer1.Start();
            //timer2.Start();
            //LoaData(x => true);

        }      
        void Splash()
        {
            SplashScreen.SplashForm fm = new SplashScreen.SplashForm();
            fm.AppName = "GLOBAL PHARMA";
            fm.BackColor = Color.White;
            fm.ForeColor = Color.SeaGreen;
            Application.Run(fm);
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoaData(x => true);
        }
        public void LoaData(Func<Utilisateur, bool> predicat)
        {
            List<string> vs = new List<string>();

            UtilisateurBLO utilisateurs = new UtilisateurBLO();
            IEnumerable<Utilisateur> us = utilisateurs.Find(predicat);
            if(us!=null )
            {
                foreach (Utilisateur u in us)
                {
                    vs.Add(u.Compte);

                }
            }

            ComboboxUtl.DataSource = vs;
            ComboboxUtl.SelectedIndex = -1;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

       

        private void Timer2_Tick(object sender, EventArgs e)
        {
        }




   

        private void GunaButton9_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
            
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            try
            {

                UtilisateurBLO utilisateurs = new UtilisateurBLO();
                Utilisateur utilisateur = utilisateurs.Login(ComboboxUtl.Text, txtMdp.Text);
                if (utilisateur != null )
                {
                    if(utilisateur.Role == Utilisateur.RoleOption.Administrateur)
                    {
                        FormDashboardPharmacie p = new FormDashboardPharmacie();
                        p.Statut.Text = utilisateur.Nom_Complet + "-" + utilisateur.Role.ToString()
                            + " - Derniere Connexion :" +
                            (utilisateur.LasConnexionDate?.ToString() ?? "Jamais");
                        p.txtNom.Text = utilisateur.Nom_Complet;

                        p.Show();
                        closeApp = false;
                        this.Close();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // gerer l'oubli du mot de passe
                }
                if (utilisateur != null)
                {
                    if (utilisateur.Role == Utilisateur.RoleOption.Employee)
                    {
                        FormDashboardPharmacie p = new FormDashboardPharmacie();
                        p.Statut.Text = utilisateur.Nom_Complet + "-" + utilisateur.Role.ToString()
                            + " - Derniere Connexion :" +
                            (utilisateur.LasConnexionDate?.ToString() ?? "Jamais");
                        p.txtNom.Text = utilisateur.Nom_Complet;
                        p.BtnAchat.Enabled = false;
                        p.gunaButton5.Enabled = false;
                        p.BtnParametre.Enabled = false;
                        p.BtnTresorie.Enabled = false;
                        p.BtnHistAchat.Enabled = false;
                        p.gunaButton3.Enabled = false;
                        p.Show();
                        closeApp = false;
                        this.Close();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // gerer l'oubli du mot de passe
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            
         


        }

        private void PanelControls_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApp)
                Application.Exit();
        }

        private void BtnConnexion_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void BtnConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
                    UtilisateurBLO utilisateurs = new UtilisateurBLO();
                    Utilisateur utilisateur = utilisateurs.Login(ComboboxUtl.Text, txtMdp.Text);
                    if (utilisateur != null)
                    {
                        FormDashboardPharmacie p = new FormDashboardPharmacie();
                        p.Statut.Text = utilisateur.Nom_Complet + "-" + utilisateur.Role.ToString()
                            + " - Derniere Connexion :" +
                            (utilisateur.LasConnexionDate?.ToString() ?? "Jamais");
                        p.txtNom.Text = utilisateur.Nom_Complet;

                        p.Show();
                        closeApp = false;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // gerer l'oubli du mot de passe
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
