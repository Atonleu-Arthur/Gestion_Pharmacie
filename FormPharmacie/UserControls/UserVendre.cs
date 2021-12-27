using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPharmacie.UserControls
{
    public partial class UserVendre : UserControl
    {
        public UserVendre()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void UserVendre_Load(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            using(FormTerminerVente ft=new FormTerminerVente())
            {
                ft.ShowDialog();
            }
        }
    }
}
