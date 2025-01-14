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
    public partial class FrmAjoutMédoc : Form
    {
        private gsb2023_sqlserverEntities3 mesDonneesMD;
        public FrmAjoutMédoc(gsb2023_sqlserverEntities3 mesDonneesMD)
        {
            InitializeComponent();
            this.mesDonneesMD = mesDonneesMD;
            this.BdgSourceAjoutMédoc.DataSource = mesDonneesMD.medicament.ToList();
            this.TxtBxNomNewMédoc.Text = this.getNumMedoc().ToString();
        }

        private void FrmAjoutMédoc_Load(object sender, EventArgs e)
        {
            this.TxtBxNomNewMédoc.Text = this.getNumMedoc().ToString();
        }

        private string getNumMedoc()
        {
            var reqDernier = (from Med in this.mesDonneesMD.medicament
                              orderby Med.id descending
                              select Med);
            medicament dernierMedoc = reqDernier.First();
            string n = dernierMedoc.id + 1;
            return n;
        }

        private void BdgNavAjoutMédoc_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BdgSourceAjoutMédoc.EndEdit();
            try
            {
                this.mesDonneesMD.medicament.Add(newMedicament());
                this.mesDonneesMD.SaveChanges();
                MessageBox.Show("Enregistrement Valider");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        /*private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BdgSourceAjoutMédoc.EndEdit();
            try
            {
                // Ajouter un nouvel objet médicament au DbSet
                this.mesDonneesMD.medicament.Add(newMedicament());

                // Sauvegarder les changements via DbContext
                this.mesDonneesMD.SaveChanges();

                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
            }
        }*/

        private medicament newMedicament()
        {
            medicament newMedicament = new medicament();
            newMedicament.nomCommercial = Convert.ToString(TxtBxNomNewMédoc.Text);
            newMedicament.composition = TxtBxCompositionNewMédoc.Text;
            newMedicament.effets = TxtBxEffetNewMédoc.Text;
            newMedicament.contreIndications = TxtBxContreIndicationNewMédoc.Text;
            return newMedicament;
        }
    }
}
