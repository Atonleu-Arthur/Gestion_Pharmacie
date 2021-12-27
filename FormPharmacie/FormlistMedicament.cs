using Excel;
using Microsoft.Office.Interop.Excel;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;




namespace FormPharmacie
{
    public partial class FormlistMedicament : Form
    {
        private Medicament Medicament  { get; set; }
       

        public string Chemin;
     
        public FormlistMedicament()
        {
            InitializeComponent();
            
        }
        public int autogen()
        {
            string num = "1234554445656789";
            int leng = num.Length;
            string opt = string.Empty;
            int optdigit = 5;
            string finaldigit;
            int getindex;
            for(int i=0; i<optdigit;i++)
            {
                do
                {
                    getindex = new Random().Next(0, leng);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (opt.IndexOf(finaldigit) != -1);
                opt += finaldigit;
            }
            return Convert.ToInt32(opt);
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Loadata(Func<Medicament, bool> predicat)
        {

            MedicamentBLL medicament = new MedicamentBLL();
            IEnumerable<Medicament> us = medicament.Find(predicat);
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = us;
            DataGridView1.AutoGenerateColumns = false;

          

        }
      

        //public void   Openfile()
        //{
        //    FicheMedocsExcel excel = new FicheMedocsExcel(Open(),1);
        //    MedicamentBLL medicament = new MedicamentBLL();
        //    Medicament medoc;
        //    try
        //    {

        //        for (int p = 1; p <= endi - starty;p++ )
        //        {
        //            for (int q = 1; q <= endy - starty; q++)
        //            {
        //                string[,] read = excel.ReadRange(1, 1, 2, 5);

        //                var a = read;

        //                medoc = new Medicament
        //                         (
        //                         a[p - 1, q - 1],
        //                         a[p - 1, q - 1],
        //                         a[p - 1, q - 1],
        //                         a[p - 1, q - 1],

        //                         a[p - 1, q - 1]);
                       
                        
        //                    if (Medicament == null)
        //                    {
        //                     do
        //                    {
        //                        medicament.Add(medoc);

        //                    }while(endi==2 && endy==5);


        //                       MessageBox.Show("Ajout Reussi !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                        //FormGestUtilisateur f = formOwner as FormGestUtilisateur;

        //                        Loadata(x => true);

        //                    }
        //                    else
        //                    {
        //                        //newmedoc = medicament.Edit(medoc, newmedoc);
        //                        MessageBox.Show("Liste modifier avec succes!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                        this.Close();
        //                    }
                        
                       
        //            }
        //        }
               

              
        //        //Medicament medoc = new Medicament(excel.ReadCell(0, 0), excel.ReadCell(0, 1), excel.ReadCell(0, 2), excel.ReadCell(0, 3), excel.ReadCell(0, 4));

        //        //Medicament newmedoc = new Medicament(excel.ReadCell(0, 0), excel.ReadCell(0, 1), excel.ReadCell(0, 2), excel.ReadCell(0, 3), excel.ReadCell(0, 4));


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //    //Loadata(x => true);
        //}
        public string Open ()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Files|*.txt";
                ofd.Title = "Choisir un fichier Excel";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                  Chemin= ofd.FileName;
                }
            }
            return Chemin;
        }
        private void FormlistMedicament_Load(object sender, EventArgs e)
        {
            Loadata(x => true);
            //if (istrue == true) 
            //Openfile();
        }

        private void ImporterListExcel_Click(object sender, EventArgs e)
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
                           
                         
                        }
                        Loadata(x => true);
                    }
                }


            }
            catch (Exception ex)
            {
               
                MessageBox.Show( "Erreur", ex.Message+" Veillez le supprimer le dans le fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
     

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            Loadata(x => true);
            //try
            //{
            //    if (DataGridView1.SelectedRows.Count > 0)
            //    {
            //        if (MessageBox.Show("Voulez vouz vraiment supprimer cette medicament?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            MedicamentBLL medicament = new MedicamentBLL();
            //            foreach (DataColumn lvi in DataGridView1.SelectedRows)
            //            {
            //                Medicament u = (Medicament)DataGridView1.SelectedRows[0].Tag;
            //                medicament.Remove(u);
            //            }
            //            //PanelRecherche_TextChanged(sender, e);
            //            MessageBox.Show("Supprimer avec sucess!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //        else
            //        {
            //            MessageBox.Show("Vous devez selectionner un element dans la liste", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

      

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            FormFicheNomenclature f = new FormFicheNomenclature();
            f.Show();
            this.Close();
           
        }

        private void PanelRecherche_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Loadata(x =>
         (x.Nom_medicament.ToLower().Contains(PanelRecherche.Text)
           || x.Nom_medicament.ToUpper().Contains(PanelRecherche.Text))
              );
        }

      

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                FormFicheNomenclature formFiche = new FormFicheNomenclature(
                    this, DataGridView1.SelectedRows[0].DataBoundItem as Medicament);

                formFiche.ShowDialog();
                this.Close();
            }
        }
    }
}
