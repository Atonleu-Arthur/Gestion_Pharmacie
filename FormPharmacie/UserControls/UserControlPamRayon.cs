using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetPharmacie.BO;
using ProjetPharmacie.Multicouche.DAL;
using ProjetPharmacie.Multicouche.BLL;

namespace FormPharmacie.UserControls
{
    public partial class UserControlPamRayon : UserControl
    {
        public Groupe Groupe  { get; set; }
        public UserControlPamRayon()
        {
            InitializeComponent();
            LoadataGrpe(x => true);

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
         
        }
        public void Init()
        {
            txtQuafRayon.Text = null;
            comboxGroupe.SelectedIndex = -1;
        }
    
        public void AddControlTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(c);
            panelCenter.BringToFront();


        }
        public void LoadData(Func<Rayon,bool> predicat)
        {
            RayonBLO rayon = new RayonBLO();
            IEnumerable<Rayon> rayons = rayon.Find(predicat);
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = rayons;
        }
           
        private void UserControlPamRayon_Load(object sender, EventArgs e)
        {
            LoadataGrpe(x => true);

        }

        private void BtnFermer_Click_1(object sender, EventArgs e)
        {

            panelCentre1.Visible = false;
            UserControlParametre user = new UserControlParametre();
            AddControlTopanel(user);
        }

        private void BtnEnregistrer1_Click_1(object sender, EventArgs e)
        {
            try
            {
                RayonBLO rayon = new RayonBLO();
                Rayon rayon1 = new Rayon
                    (
                    txtQuafRayon.Text, comboxGroupe.SelectedItem.ToString()

                    );
                if (Groupe == null)
                {
                    rayon.Add(rayon1);
                }
                Init();
                MessageBox.Show("Enregistrement réussi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(x => true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PanelCentre1_Paint(object sender, PaintEventArgs e)
        {
            LoadData(x => true);

        }
    }
}
