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

namespace FormPharmacie.UserControls
{
    public partial class UserControlInventaire : UserControl
    {
        public UserControlInventaire()
        {
            InitializeComponent();
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
                if ((int)DataGridView1.Rows[i].Cells[7].Value == 0)
                {
                    MessageBox.Show(DataGridView1.Rows[i].Cells[0].Value.ToString() + " A epuisement", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Crimson;
                }
                else
                {
                    DataGridView1.Rows[i].Cells[8].Style.BackColor = Color.LightGreen;

                }
            }

        }

        private void UserControlInventaire_Load(object sender, EventArgs e)
        {
            LoadataAchat(x => true);

        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count>0)
            {
                FormEditQuantiteInve f = new FormEditQuantiteInve
                    (this, DataGridView1.SelectedRows[0].DataBoundItem as Achat
                    );
                f.ShowDialog();
            }
        }
    }
}
