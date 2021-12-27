using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.BO;

namespace FormPharmacie.UserControls
{
    public partial class UserControlMedicament : UserControl
    {
        public Medicament Medicament  { get; set; }
        public string Chemin;
        public UserControlMedicament()
        {
            InitializeComponent();
        }
        public void Loadata(Func<Medicament, bool> predicat)
        {

            MedicamentBLL medicament = new MedicamentBLL();
            IEnumerable<Medicament> us = medicament.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = us;
            DataGridView1.AutoGenerateColumns = false;



        }
        private void GunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }


        private void BtnFermer_Click(object sender, EventArgs e)
        {

        }

        private void BtnFermer_Click_1(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlFichier user = new UserControlFichier();
            AddControlTopanel(user);
        }


       

        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            Loadata(x =>
     (x.Nom_medicament.ToLower().Contains(txtRecherche.Text)
       || x.Nom_medicament.ToUpper().Contains(txtRecherche.Text))
          );
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void PanelCentre1_Paint(object sender, PaintEventArgs e)
        {
            Loadata(x => true);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 1)
            {
                FormNomenclatureMedoc f = new FormNomenclatureMedoc(this,
                        DataGridView1.SelectedRows[0].DataBoundItem as Medicament);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veillez choisir une colonne ou selectionner d'abord une colonne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtnRenitialiser_Click(object sender, EventArgs e)
        //{
        //    txtCondi.Text = null;
        //    txtDCI.Text = null;
        //    txtDosage.Text = null;
        //    TxtForme.Text = null; /*&& ComboboxRayon.SelectedIndex==-1*/
        //    comboxGroupe.SelectedIndex = -1;
        //    txtNommedoc.Text = null;
        //}

        private void BtnAjoutMedocs_Click(object sender, EventArgs e)
        {
          
            FormNomenclatureMedoc f = new FormNomenclatureMedoc();
            f.ShowDialog();
        }
    }
}
