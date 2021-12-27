using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie
{
    public partial class FormNomenclatureMedoc : Form
    {
        public Medicament Medicament { get; set; }
        public string Chemin;
        private UserControl FormOwner { get; set; }
        public FormNomenclatureMedoc( UserControl owner)
        {
            InitializeComponent();
            FormOwner=owner ;
            LoadataGrpe(x => true);
        }
        public FormNomenclatureMedoc()
        {
            InitializeComponent();
            LoadataGrpe(x => true);
        }
        public FormNomenclatureMedoc(UserControl owner , Medicament medicament) :this(owner)
        {
            Medicament = medicament;
            if (Medicament != null)
            {
                //BtnEnregistrer1.Text = "Modifier";
                txtCondi.Text = medicament.Conditionnement.ToString();
                txtDCI.Text = medicament.DCI.ToString();
                txtDosage.Text = medicament.Dosage.ToString();
                TxtForme.Text = medicament.Forme.ToString();
                txtNommedoc.Text = medicament.Nom_medicament.ToString();
                comboxGroupe.SelectedItem = medicament.Groupe.ToString();
                //ComboboxRayon.SelectedItem = medicament.Rayon.ToString();

            }
        }

        public void LoadataGrpe(Func<Groupe, bool> predicat)
        {

            GroupeBLO groupes = new GroupeBLO();
            IEnumerable<Groupe> utl = groupes.Find(predicat);
            List<string> groupe = new List<string>();
            foreach (Groupe g in utl)
            {
                groupe.Add(g.Nom_groupe);
            }
            comboxGroupe.DataSource = groupe;
            comboxGroupe.SelectedIndex = -1;
            comboxGroupe.Refresh();
            //if (groupe != null)
            //{
            //    comboxGroupe.DataSource = groupe;
            //    comboxGroupe.SelectedIndex = 0;
            //    comboxGroupe.Refresh();
            //}


        }

        private void BtnEnregistrer1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    MedicamentBLL medicaments = new MedicamentBLL();
                    Medicament newmedocs = new Medicament
                        (new Groupe(comboxGroupe.SelectedItem.ToString()), (Rayon)ComboboxRayon.SelectedItem,
                        txtNommedoc.Text, txtDCI.Text, txtDosage.Text, TxtForme.Text, txtCondi.Text
                        );
                    Medicament oldmedocs = new Medicament
                       (new Groupe(comboxGroupe.SelectedItem.ToString()), (Rayon)ComboboxRayon.SelectedItem,
                       txtNommedoc.Text, txtDCI.Text, txtDosage.Text, TxtForme.Text, txtCondi.Text
                       );
                    if (Medicament == null)
                    {
                        verification();
                        medicaments.Add(oldmedocs);
                        MessageBox.Show("Enregistrement réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserControls.UserControlMedicament f = FormOwner as UserControls.UserControlMedicament;
                        f.Loadata(x => true);
                    }
                    else
                    {

                        medicaments.Edit(oldmedocs, newmedocs);
                        MessageBox.Show("Modification réeussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //BtnEnregistrer1.Text = "Enregistrer";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            
        }
        public void verification()
        {
            if (txtCondi.Text == null && txtDCI.Text == null && txtDosage.Text == null && TxtForme.Text == null /*&& ComboboxRayon.SelectedIndex==-1*/ && comboxGroupe.SelectedIndex == -1 && txtNommedoc.Text == null)
            {
                MessageBox.Show("Formulaire vide. Enregistrement imposible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Medicament LectureFichier(string data)
        {

            string[] t = data.Split('|');
            return new Medicament
                 (
                 new Groupe(t[0]),
                 new Rayon(t[1]),
                 t[2],
                 t[3],
                 t[4],
                 t[5],
                 t[6]

                 );

        }
        private void ImporterListExcel_Click(object sender, EventArgs e)
        {
            
        }

        public string Open()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Files|*.txt";
                ofd.Title = "Choisir un fichier Excel";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Chemin = ofd.FileName;
                }
            }
            return Chemin;
        }

        private void ImporterListExcel_Click_1(object sender, EventArgs e)
        {
            try
            {
                MedicamentBLL bLL = new MedicamentBLL();

                FileInfo fi = new FileInfo(Open());


                if (fi.Length > 0)
                {

                    using (StreamReader sr = new StreamReader(fi.FullName))
                    {
                        string line = null;
                        while ((line = sr.ReadLine()) != null)
                        {

                            bLL.Add(LectureFichier(line));
                            MessageBox.Show(bLL.Find(x => true).Count().ToString());

                        }

                        UserControls.UserControlMedicament f = FormOwner as UserControls.UserControlMedicament;
                        f.Loadata(x => true);
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur", ex.Message + " Veillez le supprimer le dans le fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboxGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
