using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie;
using System.Threading;

namespace FormPharmacie.UserControls
{
    public partial class FormAjoutMedicament : Form
    {
      
        private Medicament Medicament { get; set; }
        private UserControl formOwner { get; set; }

      
        public FormAjoutMedicament(UserControl owner)
        {
            InitializeComponent();
            formOwner = owner;

        }
        public FormAjoutMedicament(UserControl owner, Medicament medicament) : this(owner)
        {
            Medicament = medicament;
            if (Medicament != null)
            {
                TxtNomInfos.Text = medicament.Remarque; 
                TxtNomMedicament.Text = medicament.Nom_medicament;
            
            }

        }

        public void InitForm()
        {
            TxtNomInfos.Text = null;
            TxtNomMedicament.Text = null;
 
        }
      

        private void FormAjoutMedicament_Load(object sender, EventArgs e)
        {

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CheckForm()
        {
            if(TxtNomInfos==null || TxtNomMedicament==null)
            {
                MessageBox.Show("Attention", "Entrer un nom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {

                CheckForm();
                MedicamentBLL medicaments = new MedicamentBLL();

                Medicament newmedocs = new Medicament(0, TxtNomMedicament.Text, TxtNomInfos.Text);

                Medicament oldmedocs = new Medicament(0, TxtNomMedicament.Text, TxtNomInfos.Text);
                if (Medicament == null)
                {
                  
                    medicaments.Add(oldmedocs);
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitForm();
                    //FormGestUtilisateur f = formOwner as FormGestUtilisateur;
                    UserControls.UserMedicament f = formOwner as UserControls.UserMedicament;
                    f?.LoadDataM(x => true);

                }
                else
                {
                    newmedocs = medicaments.Edit(oldmedocs, newmedocs);
                    //utilisateurs[utilisateur.Compte] = utilisateur;
                    //FormGestUtilisateur f = Owner as FormGestUtilisateur;
                    //f?.LoadData(x => true);
                    //utilisateurs[Utilisateur.Compte] = utilisateur;
                    MessageBox.Show("Enregistrement réussi", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
