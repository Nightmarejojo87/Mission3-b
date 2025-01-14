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
    public partial class FormGererMedoc2 : Form
    {
        private gsb2023_sqlserverEntities3 mesDonneeMD;
        private Dictionary<string, int> medoc = new Dictionary<string, int>();

        public FormGererMedoc2(gsb2023_sqlserverEntities3 mesDonneeMD)
        {
            InitializeComponent();
            this.mesDonneeMD = mesDonneeMD;
            this.bdgMedocs.DataSource = mesDonneeMD.medicament.ToList();
        }

        private medicament newMedicament()
        {
            medicament newMedicament = new medicament();
            return newMedicament;
        }

        private void FormGererMedoc2_Load(object sender, EventArgs e)
        {

        }

        private void btnModifGereMedoc_Click(object sender, EventArgs e)
        {
            this.bdgMedocs.EndEdit();
            try
            {
                this.mesDonneeMD.medicament.Add(newMedicament);
                this.mesDonneeMD.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"erreur lors de l'enregistrement : {ex.Message}");
            }
        }
    }
}
