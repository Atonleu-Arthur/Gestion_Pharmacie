using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie;
using ProjetPharmacie.Multicouche.BLL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlStockSG : UserControl
    {
        public UserControlStockSG()
        {
            InitializeComponent();
        }

        private void UserControlStockSG_Load(object sender, EventArgs e)
        {
            LoadataAchat(x => true);
        }
        public void LoadataAchat(Func<Achat,bool> predicat)
        {
            AchatBLO historiques = new AchatBLO();
            IEnumerable<Achat> listeA = historiques.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = listeA;
            lbl.Text = DataGridView1.RowCount.ToString();
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if ((int)DataGridView1.Rows[i].Cells[3].Value == 2)
                {
                    DataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Crimson;
                }
                else
                {
                    DataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;

                }
            }
        }
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }

      
        private void BtnFermer_Click_1(object sender, EventArgs e)
        {
            panelCentre1.Visible = false;
            UserControlStockP user = new UserControlStockP();
            AddControlTopanel(user);
        }

        private void PanelCentre1_Click(object sender, EventArgs e)
        {

        }
    }
}
