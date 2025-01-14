namespace Mission3
{
    partial class FormGererMedoc2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvGereMedoc2 = new System.Windows.Forms.DataGridView();
            this.btnModifGereMedoc = new System.Windows.Forms.Button();
            this.btnValideGereMedoc = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedocs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGereMedoc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedocs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGereMedoc2
            // 
            this.dgvGereMedoc2.AutoGenerateColumns = false;
            this.dgvGereMedoc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGereMedoc2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn,
            this.offrirDataGridViewTextBoxColumn});
            this.dgvGereMedoc2.DataSource = this.bdgMedocs;
            this.dgvGereMedoc2.Location = new System.Drawing.Point(12, 12);
            this.dgvGereMedoc2.Name = "dgvGereMedoc2";
            this.dgvGereMedoc2.Size = new System.Drawing.Size(776, 282);
            this.dgvGereMedoc2.TabIndex = 0;
            // 
            // btnModifGereMedoc
            // 
            this.btnModifGereMedoc.Location = new System.Drawing.Point(12, 328);
            this.btnModifGereMedoc.Name = "btnModifGereMedoc";
            this.btnModifGereMedoc.Size = new System.Drawing.Size(75, 23);
            this.btnModifGereMedoc.TabIndex = 1;
            this.btnModifGereMedoc.Text = "Modifier";
            this.btnModifGereMedoc.UseVisualStyleBackColor = true;
            this.btnModifGereMedoc.Click += new System.EventHandler(this.btnModifGereMedoc_Click);
            // 
            // btnValideGereMedoc
            // 
            this.btnValideGereMedoc.Location = new System.Drawing.Point(132, 328);
            this.btnValideGereMedoc.Name = "btnValideGereMedoc";
            this.btnValideGereMedoc.Size = new System.Drawing.Size(75, 23);
            this.btnValideGereMedoc.TabIndex = 2;
            this.btnValideGereMedoc.Text = "Valider";
            this.btnValideGereMedoc.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "identifiant";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nom du médicament";
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "identifiant de la famille";
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "famille";
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            // 
            // offrirDataGridViewTextBoxColumn
            // 
            this.offrirDataGridViewTextBoxColumn.DataPropertyName = "offrir";
            this.offrirDataGridViewTextBoxColumn.HeaderText = "médicament offert";
            this.offrirDataGridViewTextBoxColumn.Name = "offrirDataGridViewTextBoxColumn";
            // 
            // bdgMedocs
            // 
            this.bdgMedocs.DataSource = typeof(Mission3.medicament);
            // 
            // FormGererMedoc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValideGereMedoc);
            this.Controls.Add(this.btnModifGereMedoc);
            this.Controls.Add(this.dgvGereMedoc2);
            this.Name = "FormGererMedoc2";
            this.Text = "Gestion de médicaments";
            this.Load += new System.EventHandler(this.FormGererMedoc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGereMedoc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGereMedoc2;
        private System.Windows.Forms.Button btnModifGereMedoc;
        private System.Windows.Forms.Button btnValideGereMedoc;
        private System.Windows.Forms.BindingSource bdgMedocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
    }
}