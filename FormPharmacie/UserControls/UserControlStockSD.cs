using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie.Multicouche.BLL;
using ProjetPharmacie;
using Microsoft.Office.Interop.Excel;

namespace FormPharmacie.UserControls
{
    public partial class UserControlStockSD : UserControl
    {
        public UserControlStockSD()
        {
            InitializeComponent();
        }

        private void GunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadataAchat(Func<Achat, bool> predicat)
        {

            AchatBLO historiques = new AchatBLO();
            IEnumerable<Achat> listeA = historiques.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = listeA;
            lbl.Text = DataGridView1.RowCount.ToString();
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if((int)DataGridView1.Rows[i].Cells[8].Value==0)
                {
                    MessageBox.Show(DataGridView1.Rows[i].Cells[0].Value.ToString() + " A epuisement", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                    DataGridView1.Rows[i].Cells[8].Style.ForeColor  = Color.Crimson;
                }
                else
                {
                    DataGridView1.Rows[i].Cells[8].Style.BackColor = Color.LightGreen;

                }
            }

        }

        private void UserControlStockSD_Load(object sender, EventArgs e)
        {
            LoadataAchat(x => true);
        }

        private void ImporterListExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", ValidateNames = true })
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    // Ajouter des lignes sur Excel
                    ws.Cells[1, 1] = "Produit";
                    ws.Cells[1, 2] = "Lot";
                    ws.Cells[1, 3] = "Date d'entrée";
                    ws.Cells[1, 4] = "Prix d'achat";
                    ws.Cells[1, 5] = "Tva";
                    ws.Cells[1, 6] = "Marge";
                    ws.Cells[1, 7] = "Prix de vente";
                    ws.Cells[1, 8] = "Quantité";
                    ws.Cells[1, 9] = "Stock actuel";
                    ws.Cells[1, 10] = "Peremption";
                    ws.Cells[1, 11] = "Code barre";
                    ws.Cells[1, 12] = "Fournisseur";
                    // Ajout de la liste des produits dans le fichier sue Excel
                    AchatBLO historiques = new AchatBLO();
                    IEnumerable<Achat> listeA = historiques.Find(x => true);
                    int i = 2;
                    foreach (Achat a in listeA)
                    {
                        ws.Cells[i, 1] = a.Nom_medicament;
                        ws.Cells[i, 2] = a.Numero_lot;
                        ws.Cells[i, 3] = a.Date_achat;
                        ws.Cells[i, 4] = a.Prix_achat;
                        ws.Cells[i, 5] = null;
                        ws.Cells[i, 6] = a.Marge;
                        ws.Cells[i, 7] = a.Prix_Vente;
                        ws.Cells[i, 8] = a.Quantite;
                        ws.Cells[i, 9] = a.Quantite_stock;
                        ws.Cells[i, 10] = a.Date_Expiration;
                        ws.Cells[i, 11] = a.Code_barre;
                        //ws.Cells[i, 12] = a.Fournisseur;
                        i++;
                    }
                    // changer 
                    ws.Range["A1:L1"].Interior.Color = Color.SeaGreen;
                    ws.Range["A1:L1"].Font.Color = Color.White;
                    ws.Range["A1:L1"].Font.Size = 12;
                    //ws.Range["A:L"].HorizontalAlignment = XlHAlign.xlHAlignCenter;


                    wb.SaveAs(SFD.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarder avec success dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                }


            }


        }
    }
}
