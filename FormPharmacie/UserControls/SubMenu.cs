using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace FormPharmacie.UserControls
{
    public partial class SubMenu : UserControl
    {
        public SubMenu()
        {
            InitializeComponent();
            if(Program.IsIndesignMode()) return;
            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void GunaButton19_Click(object sender, EventArgs e)
        {

        }

        private void SubMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
