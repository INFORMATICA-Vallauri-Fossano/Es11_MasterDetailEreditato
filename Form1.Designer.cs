namespace Es11_MasterDetailEreditato
{
    partial class frmBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnagrafica = new System.Windows.Forms.Button();
            this.btnClassi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnagrafica
            // 
            this.btnAnagrafica.Location = new System.Drawing.Point(34, 50);
            this.btnAnagrafica.Name = "btnAnagrafica";
            this.btnAnagrafica.Size = new System.Drawing.Size(95, 27);
            this.btnAnagrafica.TabIndex = 0;
            this.btnAnagrafica.Text = "Anagrafica";
            this.btnAnagrafica.UseVisualStyleBackColor = true;
            this.btnAnagrafica.Click += new System.EventHandler(this.btnAnagrafica_Click);
            // 
            // btnClassi
            // 
            this.btnClassi.Location = new System.Drawing.Point(34, 83);
            this.btnClassi.Name = "btnClassi";
            this.btnClassi.Size = new System.Drawing.Size(95, 27);
            this.btnClassi.TabIndex = 1;
            this.btnClassi.Text = "Classi";
            this.btnClassi.UseVisualStyleBackColor = true;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 151);
            this.Controls.Add(this.btnClassi);
            this.Controls.Add(this.btnAnagrafica);
            this.Name = "frmBase";
            this.Text = "Form Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnagrafica;
        private System.Windows.Forms.Button btnClassi;
    }
}

