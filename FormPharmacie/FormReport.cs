using ProjetPharmacie;
using ProjetPharmacie.BO;
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
    public partial class FormReport : Form
    {
        private List<HistoriqueVente> Lhistorique = null;
        private List<Vente> Lvente;
        private List<Vente> Vente  { get; set; }
        private HistoriqueVente HistoriqueVente  { get; set; }

        public FormReport()
        {
            InitializeComponent();
        }
        public FormReport(HistoriqueVente historique, List<Vente> vente )
        {
            InitializeComponent();
            HistoriqueVente = historique;
            Vente = vente;
            Lhistorique = new List<HistoriqueVente>();
            Lhistorique.Add(HistoriqueVente);
            Lvente = new List<Vente>(vente);

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportVente.rdlc";

            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportVente.rdlc";
            reportViewer1.LocalReport.DataSources.Add(
               new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1" ,Lvente  ));
            reportViewer1.LocalReport.DataSources.Add(
              new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", Lhistorique));
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
