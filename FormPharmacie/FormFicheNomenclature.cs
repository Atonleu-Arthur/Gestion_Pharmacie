using ProjetPharmacie;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.BLL;
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

namespace FormPharmacie
{
    public partial class FormFicheNomenclature : Form
    {
        private Form formOwner { get; set; }
        private Medicament Medicament  { get; set; }
        FormChoixProduit formChoix = new FormChoixProduit();

        public FormFicheNomenclature(Form owner)
        {
            InitializeComponent();
            LoadataGrpe(x => true);
            formOwner = owner; // ajouter la possibilite  d'ajouter une nouvelle famille a l'administrateur
        }
        public FormFicheNomenclature()
        {
            InitializeComponent();
            LoadataGrpe(x => true);

        }
        public void LoadataGrpe(Func<Groupe, bool> predicat)
        {

            GroupeBLO groupes = new GroupeBLO();
            IEnumerable<Groupe> utl = groupes.Find(predicat);
            if (utl != null)
            {
                ComboBoxFamille.DataSource = utl;
                ComboBoxFamille.SelectedIndex = 0;
                ComboBoxFamille.Refresh();
            }


        }
        public FormFicheNomenclature(Form owner, Medicament medicament): this(owner)
        {
            Medicament = medicament;
            if(Medicament!=null)
            {
                txtNom.Text = medicament.Nom_medicament;
                txtDCI.Text = medicament.DCI;
                txtDosage.Text = medicament.Dosage;
                txtCondi.Text = medicament.Conditionnement;
                txtForme.Text = medicament.Forme;
            }

        }

        private void BtnChoixMedoc_Click(object sender, EventArgs e)
        {
            FormlistMedicament f = new FormlistMedicament();
            f.ShowDialog();
            this.Visible = false;
            
        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {
            formChoix.LoadDataProduit(x => true);
            this.Close();
        }

        private void GunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
          

        private void FormFicheNomenclature_Load(object sender, EventArgs e)
        {
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentBLL medicament = new MedicamentBLL();
                Medicament oldmedocs = new Medicament(new Groupe(ComboBoxFamille.Text), (Rayon)ComboboxRayon.SelectedItem, txtNom.Text, txtDCI.Text, txtDosage.Text, txtForme.Text, txtCondi.Text);

                Medicament newmedocs = new Medicament(new Groupe(ComboBoxFamille.Text), (Rayon)ComboboxRayon.SelectedItem, txtNom.Text,txtDCI.Text,txtDosage.Text,txtForme.Text,txtCondi.Text);

                //    ProduitBLO produits = new ProduitBLO();
                //    //Produit produit = new Produit((Produit.Famille)ComboBoxFamille.SelectedIndex, txtNom.Text, txtDCI.Text, txtDosage.Text, txtForme.Text, txtCondi.Text,Convert.ToDouble(txtCodeBarre.Text), Convert.ToInt32(txtQte.Text));
                //    Produit produit = new Produit(txtNom.Text, Convert.ToDouble(txtCodeBarre.Text));
                //    if(Medicament!=null)
                //    {
                //        produits.Add(produit);
                //        formChoix.LoadDataProduit(x => true);
                //    }
                if (Medicament != null)
                    medicament.Edit(oldmedocs, newmedocs);
                FormChoixProduit f = new FormChoixProduit();
                f.LoadDataProduit(x => true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TxtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar< 48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if(e.KeyChar==8)
            {
                e.Handled = false;
            }
        }

        private void TxtCodeBarre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void FormFicheNomenclature_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FormFicheNomenclature_VisibleChanged(object sender, EventArgs e)
        {
            //if (isclosed)
            //    this.Visible = true;
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void TxtCodeBarre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
