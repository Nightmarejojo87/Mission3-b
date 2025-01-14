using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3
{
    public partial class FrmAccueil : Form
    {
        private gsb2023_sqlserverEntities3 mesDonneesMD;
        public FrmAccueil()
        {
            InitializeComponent();
            this.mesDonneesMD = new gsb2023_sqlserverEntities3();
        }

        private void offirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererMedoc2 GM = new FormGererMedoc2(this.mesDonneesMD);
            GM.MdiParent = this;
            GM.Show();
        }
    }
}
