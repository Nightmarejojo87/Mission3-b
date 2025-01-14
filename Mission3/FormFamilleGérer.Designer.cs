namespace Mission3
{
    partial class FrmFamilleGérer
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
            this.CBoxSelectFamille = new System.Windows.Forms.ComboBox();
            this.BtnModifFamille = new System.Windows.Forms.Button();
            this.BtnSupprFamille = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBoxSelectFamille
            // 
            this.CBoxSelectFamille.FormattingEnabled = true;
            this.CBoxSelectFamille.Location = new System.Drawing.Point(30, 60);
            this.CBoxSelectFamille.Name = "CBoxSelectFamille";
            this.CBoxSelectFamille.Size = new System.Drawing.Size(245, 21);
            this.CBoxSelectFamille.TabIndex = 0;
            this.CBoxSelectFamille.Text = "Séléctionner une famille";
            // 
            // BtnModifFamille
            // 
            this.BtnModifFamille.Location = new System.Drawing.Point(281, 60);
            this.BtnModifFamille.Name = "BtnModifFamille";
            this.BtnModifFamille.Size = new System.Drawing.Size(75, 23);
            this.BtnModifFamille.TabIndex = 1;
            this.BtnModifFamille.Text = "Modifier";
            this.BtnModifFamille.UseVisualStyleBackColor = true;
            this.BtnModifFamille.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSupprFamille
            // 
            this.BtnSupprFamille.Location = new System.Drawing.Point(281, 108);
            this.BtnSupprFamille.Name = "BtnSupprFamille";
            this.BtnSupprFamille.Size = new System.Drawing.Size(75, 23);
            this.BtnSupprFamille.TabIndex = 2;
            this.BtnSupprFamille.Text = "Supprimer";
            this.BtnSupprFamille.UseVisualStyleBackColor = true;
            // 
            // FrmFamilleGérer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSupprFamille);
            this.Controls.Add(this.BtnModifFamille);
            this.Controls.Add(this.CBoxSelectFamille);
            this.Name = "FrmFamilleGérer";
            this.Text = "Gestion des Famille de Médicaments";
            this.Load += new System.EventHandler(this.FrmFamilleGérer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxSelectFamille;
        private System.Windows.Forms.Button BtnModifFamille;
        private System.Windows.Forms.Button BtnSupprFamille;
    }
}