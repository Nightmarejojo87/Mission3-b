namespace Mission3
{
    partial class FrmAjoutMédoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutMédoc));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAjoutMédoc = new System.Windows.Forms.Button();
            this.LblNomNewMédoc = new System.Windows.Forms.Label();
            this.LblCompositionNewMédoc = new System.Windows.Forms.Label();
            this.LblEffetNewMédoc = new System.Windows.Forms.Label();
            this.LblContreIndicationNewMédoc = new System.Windows.Forms.Label();
            this.TxtBxNomNewMédoc = new System.Windows.Forms.TextBox();
            this.BdgSourceAjoutMédoc = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBxCompositionNewMédoc = new System.Windows.Forms.TextBox();
            this.TxtBxEffetNewMédoc = new System.Windows.Forms.TextBox();
            this.TxtBxContreIndicationNewMédoc = new System.Windows.Forms.TextBox();
            this.BdgNavAjoutMédoc = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Enregistrer = new System.Windows.Forms.ToolStripButton();
            this.gsb2023_sqlserverDataSet = new Mission3.gsb2023_sqlserverDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSourceAjoutMédoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgNavAjoutMédoc)).BeginInit();
            this.BdgNavAjoutMédoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2023_sqlserverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familleBindingSource, "libelle", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choisissez une famille de médicament";
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Mission3.famille);
            // 
            // BtnAjoutMédoc
            // 
            this.BtnAjoutMédoc.Location = new System.Drawing.Point(312, 51);
            this.BtnAjoutMédoc.Name = "BtnAjoutMédoc";
            this.BtnAjoutMédoc.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutMédoc.TabIndex = 1;
            this.BtnAjoutMédoc.Text = "Ajouter";
            this.BtnAjoutMédoc.UseVisualStyleBackColor = true;
            // 
            // LblNomNewMédoc
            // 
            this.LblNomNewMédoc.AutoSize = true;
            this.LblNomNewMédoc.Location = new System.Drawing.Point(24, 173);
            this.LblNomNewMédoc.Name = "LblNomNewMédoc";
            this.LblNomNewMédoc.Size = new System.Drawing.Size(29, 13);
            this.LblNomNewMédoc.TabIndex = 2;
            this.LblNomNewMédoc.Text = "Nom";
            // 
            // LblCompositionNewMédoc
            // 
            this.LblCompositionNewMédoc.AutoSize = true;
            this.LblCompositionNewMédoc.Location = new System.Drawing.Point(24, 210);
            this.LblCompositionNewMédoc.Name = "LblCompositionNewMédoc";
            this.LblCompositionNewMédoc.Size = new System.Drawing.Size(64, 13);
            this.LblCompositionNewMédoc.TabIndex = 3;
            this.LblCompositionNewMédoc.Text = "Composition";
            // 
            // LblEffetNewMédoc
            // 
            this.LblEffetNewMédoc.AutoSize = true;
            this.LblEffetNewMédoc.Location = new System.Drawing.Point(24, 247);
            this.LblEffetNewMédoc.Name = "LblEffetNewMédoc";
            this.LblEffetNewMédoc.Size = new System.Drawing.Size(29, 13);
            this.LblEffetNewMédoc.TabIndex = 4;
            this.LblEffetNewMédoc.Text = "Effet";
            // 
            // LblContreIndicationNewMédoc
            // 
            this.LblContreIndicationNewMédoc.AutoSize = true;
            this.LblContreIndicationNewMédoc.Location = new System.Drawing.Point(24, 286);
            this.LblContreIndicationNewMédoc.Name = "LblContreIndicationNewMédoc";
            this.LblContreIndicationNewMédoc.Size = new System.Drawing.Size(87, 13);
            this.LblContreIndicationNewMédoc.TabIndex = 5;
            this.LblContreIndicationNewMédoc.Text = "Contre-Indication";
            // 
            // TxtBxNomNewMédoc
            // 
            this.TxtBxNomNewMédoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdgSourceAjoutMédoc, "nomCommercial", true));
            this.TxtBxNomNewMédoc.Location = new System.Drawing.Point(124, 170);
            this.TxtBxNomNewMédoc.Name = "TxtBxNomNewMédoc";
            this.TxtBxNomNewMédoc.Size = new System.Drawing.Size(182, 20);
            this.TxtBxNomNewMédoc.TabIndex = 6;
            // 
            // BdgSourceAjoutMédoc
            // 
            this.BdgSourceAjoutMédoc.DataSource = typeof(Mission3.medicament);
            // 
            // TxtBxCompositionNewMédoc
            // 
            this.TxtBxCompositionNewMédoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdgSourceAjoutMédoc, "composition", true));
            this.TxtBxCompositionNewMédoc.Location = new System.Drawing.Point(124, 207);
            this.TxtBxCompositionNewMédoc.Name = "TxtBxCompositionNewMédoc";
            this.TxtBxCompositionNewMédoc.Size = new System.Drawing.Size(182, 20);
            this.TxtBxCompositionNewMédoc.TabIndex = 7;
            // 
            // TxtBxEffetNewMédoc
            // 
            this.TxtBxEffetNewMédoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdgSourceAjoutMédoc, "effets", true));
            this.TxtBxEffetNewMédoc.Location = new System.Drawing.Point(124, 244);
            this.TxtBxEffetNewMédoc.Name = "TxtBxEffetNewMédoc";
            this.TxtBxEffetNewMédoc.Size = new System.Drawing.Size(182, 20);
            this.TxtBxEffetNewMédoc.TabIndex = 8;
            // 
            // TxtBxContreIndicationNewMédoc
            // 
            this.TxtBxContreIndicationNewMédoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdgSourceAjoutMédoc, "contreIndications", true));
            this.TxtBxContreIndicationNewMédoc.Location = new System.Drawing.Point(124, 283);
            this.TxtBxContreIndicationNewMédoc.Name = "TxtBxContreIndicationNewMédoc";
            this.TxtBxContreIndicationNewMédoc.Size = new System.Drawing.Size(182, 20);
            this.TxtBxContreIndicationNewMédoc.TabIndex = 9;
            // 
            // BdgNavAjoutMédoc
            // 
            this.BdgNavAjoutMédoc.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BdgNavAjoutMédoc.BindingSource = this.BdgSourceAjoutMédoc;
            this.BdgNavAjoutMédoc.CountItem = this.bindingNavigatorCountItem;
            this.BdgNavAjoutMédoc.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BdgNavAjoutMédoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.Enregistrer});
            this.BdgNavAjoutMédoc.Location = new System.Drawing.Point(0, 0);
            this.BdgNavAjoutMédoc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BdgNavAjoutMédoc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BdgNavAjoutMédoc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BdgNavAjoutMédoc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BdgNavAjoutMédoc.Name = "BdgNavAjoutMédoc";
            this.BdgNavAjoutMédoc.PositionItem = this.bindingNavigatorPositionItem;
            this.BdgNavAjoutMédoc.Size = new System.Drawing.Size(618, 25);
            this.BdgNavAjoutMédoc.TabIndex = 10;
            this.BdgNavAjoutMédoc.Text = "bindingNavigator1";
            this.BdgNavAjoutMédoc.RefreshItems += new System.EventHandler(this.BdgNavAjoutMédoc_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Enregistrer
            // 
            this.Enregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(23, 22);
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gsb2023_sqlserverDataSet
            // 
            this.gsb2023_sqlserverDataSet.DataSetName = "gsb2023_sqlserverDataSet";
            this.gsb2023_sqlserverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmAjoutMédoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 464);
            this.Controls.Add(this.BdgNavAjoutMédoc);
            this.Controls.Add(this.TxtBxContreIndicationNewMédoc);
            this.Controls.Add(this.TxtBxEffetNewMédoc);
            this.Controls.Add(this.TxtBxCompositionNewMédoc);
            this.Controls.Add(this.TxtBxNomNewMédoc);
            this.Controls.Add(this.LblContreIndicationNewMédoc);
            this.Controls.Add(this.LblEffetNewMédoc);
            this.Controls.Add(this.LblCompositionNewMédoc);
            this.Controls.Add(this.LblNomNewMédoc);
            this.Controls.Add(this.BtnAjoutMédoc);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmAjoutMédoc";
            this.Text = "Ajout d\'un nouveau médicament";
            this.Load += new System.EventHandler(this.FrmAjoutMédoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSourceAjoutMédoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgNavAjoutMédoc)).EndInit();
            this.BdgNavAjoutMédoc.ResumeLayout(false);
            this.BdgNavAjoutMédoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2023_sqlserverDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAjoutMédoc;
        private System.Windows.Forms.Label LblNomNewMédoc;
        private System.Windows.Forms.Label LblCompositionNewMédoc;
        private System.Windows.Forms.Label LblEffetNewMédoc;
        private System.Windows.Forms.Label LblContreIndicationNewMédoc;
        private System.Windows.Forms.TextBox TxtBxNomNewMédoc;
        private System.Windows.Forms.TextBox TxtBxCompositionNewMédoc;
        private System.Windows.Forms.TextBox TxtBxEffetNewMédoc;
        private System.Windows.Forms.TextBox TxtBxContreIndicationNewMédoc;
        private System.Windows.Forms.BindingSource BdgSourceAjoutMédoc;
        private System.Windows.Forms.BindingNavigator BdgNavAjoutMédoc;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.ToolStripButton Enregistrer;
        private gsb2023_sqlserverDataSet gsb2023_sqlserverDataSet;
    }
}