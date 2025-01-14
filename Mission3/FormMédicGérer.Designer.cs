namespace Mission3
{
    partial class FrmMédicGérer
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
            this.CBoxSelectMédoc = new System.Windows.Forms.ComboBox();
            this.BtnModifMédoc = new System.Windows.Forms.Button();
            this.BtnSupprMédoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBoxSelectMédoc
            // 
            this.CBoxSelectMédoc.FormattingEnabled = true;
            this.CBoxSelectMédoc.Location = new System.Drawing.Point(28, 55);
            this.CBoxSelectMédoc.Name = "CBoxSelectMédoc";
            this.CBoxSelectMédoc.Size = new System.Drawing.Size(234, 21);
            this.CBoxSelectMédoc.TabIndex = 0;
            this.CBoxSelectMédoc.Text = "sélectionnez un médicament";
            this.CBoxSelectMédoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnModifMédoc
            // 
            this.BtnModifMédoc.Location = new System.Drawing.Point(268, 55);
            this.BtnModifMédoc.Name = "BtnModifMédoc";
            this.BtnModifMédoc.Size = new System.Drawing.Size(75, 23);
            this.BtnModifMédoc.TabIndex = 1;
            this.BtnModifMédoc.Text = "Modifier";
            this.BtnModifMédoc.UseVisualStyleBackColor = true;
            // 
            // BtnSupprMédoc
            // 
            this.BtnSupprMédoc.Location = new System.Drawing.Point(268, 100);
            this.BtnSupprMédoc.Name = "BtnSupprMédoc";
            this.BtnSupprMédoc.Size = new System.Drawing.Size(75, 23);
            this.BtnSupprMédoc.TabIndex = 2;
            this.BtnSupprMédoc.Text = "Supprimer";
            this.BtnSupprMédoc.UseVisualStyleBackColor = true;
            // 
            // FrmMédicGérer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSupprMédoc);
            this.Controls.Add(this.BtnModifMédoc);
            this.Controls.Add(this.CBoxSelectMédoc);
            this.Name = "FrmMédicGérer";
            this.Text = "Gestion des médicaments";
            this.Load += new System.EventHandler(this.FrmMédicGérer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxSelectMédoc;
        private System.Windows.Forms.Button BtnModifMédoc;
        private System.Windows.Forms.Button BtnSupprMédoc;
    }
}