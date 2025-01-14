namespace Mission3
{
    partial class FrmAjoutFamille
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
            this.LblIdNewFamille = new System.Windows.Forms.Label();
            this.LblLibelleNewFamille = new System.Windows.Forms.Label();
            this.TxtBxIdNewFamille = new System.Windows.Forms.TextBox();
            this.RchTxtBxLibelleNewFamille = new System.Windows.Forms.RichTextBox();
            this.BtnAjoutFamille = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIdNewFamille
            // 
            this.LblIdNewFamille.AutoSize = true;
            this.LblIdNewFamille.Location = new System.Drawing.Point(12, 55);
            this.LblIdNewFamille.Name = "LblIdNewFamille";
            this.LblIdNewFamille.Size = new System.Drawing.Size(16, 13);
            this.LblIdNewFamille.TabIndex = 0;
            this.LblIdNewFamille.Text = "Id";
            // 
            // LblLibelleNewFamille
            // 
            this.LblLibelleNewFamille.AutoSize = true;
            this.LblLibelleNewFamille.Location = new System.Drawing.Point(12, 84);
            this.LblLibelleNewFamille.Name = "LblLibelleNewFamille";
            this.LblLibelleNewFamille.Size = new System.Drawing.Size(37, 13);
            this.LblLibelleNewFamille.TabIndex = 1;
            this.LblLibelleNewFamille.Text = "Libelle";
            // 
            // TxtBxIdNewFamille
            // 
            this.TxtBxIdNewFamille.Location = new System.Drawing.Point(67, 52);
            this.TxtBxIdNewFamille.Name = "TxtBxIdNewFamille";
            this.TxtBxIdNewFamille.Size = new System.Drawing.Size(143, 20);
            this.TxtBxIdNewFamille.TabIndex = 2;
            // 
            // RchTxtBxLibelleNewFamille
            // 
            this.RchTxtBxLibelleNewFamille.Location = new System.Drawing.Point(67, 81);
            this.RchTxtBxLibelleNewFamille.Name = "RchTxtBxLibelleNewFamille";
            this.RchTxtBxLibelleNewFamille.Size = new System.Drawing.Size(143, 123);
            this.RchTxtBxLibelleNewFamille.TabIndex = 3;
            this.RchTxtBxLibelleNewFamille.Text = "";
            // 
            // BtnAjoutFamille
            // 
            this.BtnAjoutFamille.Location = new System.Drawing.Point(237, 50);
            this.BtnAjoutFamille.Name = "BtnAjoutFamille";
            this.BtnAjoutFamille.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutFamille.TabIndex = 4;
            this.BtnAjoutFamille.Text = "Ajouter";
            this.BtnAjoutFamille.UseVisualStyleBackColor = true;
            this.BtnAjoutFamille.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 570);
            this.Controls.Add(this.BtnAjoutFamille);
            this.Controls.Add(this.RchTxtBxLibelleNewFamille);
            this.Controls.Add(this.TxtBxIdNewFamille);
            this.Controls.Add(this.LblLibelleNewFamille);
            this.Controls.Add(this.LblIdNewFamille);
            this.Name = "FrmAjoutFamille";
            this.Text = "Ajout d\'une nouvelle famille de médicament";
            this.Load += new System.EventHandler(this.FrmAjoutFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIdNewFamille;
        private System.Windows.Forms.Label LblLibelleNewFamille;
        private System.Windows.Forms.TextBox TxtBxIdNewFamille;
        private System.Windows.Forms.RichTextBox RchTxtBxLibelleNewFamille;
        private System.Windows.Forms.Button BtnAjoutFamille;
    }
}