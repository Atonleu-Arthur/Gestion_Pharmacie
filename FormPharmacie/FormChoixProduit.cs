using FormPharmacie.UserControls;
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
    public partial class FormChoixProduit : Form
    {
        public Medicament Medicament { get; set; }
        private Rayon rayon;
        public Rayon Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        private Groupe groupe;
        public Groupe Groupe
        {
            get { return groupe; }
            set { groupe = value; }
        }
        private string dci;
        public string Dci
        {
            get { return dci; }
            set { dci = value; }
        }
        private string nomproduit;
        public string Nomproduit
        {
            get { return nomproduit; }
            set { nomproduit = value; }
        }

        public FormChoixProduit()
        {
            InitializeComponent();

        }
      
  
        private void BtnAjoutProduit_Click(object sender, EventArgs e)
        {
            FormFicheNomenclature f = new FormFicheNomenclature();
            f.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDataProduit(Func<Medicament, bool> predicat)
        {
            MedicamentBLL medicament = new MedicamentBLL();
            IEnumerable<Medicament> us = medicament.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = us;
        }
       
        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                Medicament = DataGridView1.SelectedRows[0].DataBoundItem as Medicament;

                if (Medicament != null)
                {
                    Nomproduit = (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Nom_medicament;

                }
                //chargetext(listView1.SelectedItems[0].Tag as Produit);

                this.Close();

            }
        }
        public void ChargeTxtProduit()
        {

           
        }

        private void FormChoixProduit_Load(object sender, EventArgs e)
        {
            LoadDataProduit(x => true);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                Medicament = DataGridView1.SelectedRows[0].DataBoundItem as Medicament;

                if (Medicament != null)
                {
                    Nomproduit = (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Nom_medicament +
                                 (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).DCI +
                    (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Dosage +
                        (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Forme +
                        (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Conditionnement;
                    Dci = (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).DCI;
                    groupe = (DataGridView1.SelectedRows[0].DataBoundItem as Medicament).Groupe;
                    

                }

                this.Close();

            }

        }

        private void GunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDataProduit(x =>
        (x.Nom_medicament.ToLower().Contains(txtrechercher.Text)
        || x.Nom_medicament.ToUpper().Contains(txtrechercher.Text) && (x.DCI.ToUpper().Contains(txtrechercher.Text) || x.DCI.ToLower().Contains(txtrechercher.Text))
        && (x.Dosage.Contains(txtrechercher.Text)))
        ) ;
        }
    }
}

