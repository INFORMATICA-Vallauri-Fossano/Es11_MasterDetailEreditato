namespace Es11_MasterDetailEreditato
{
    partial class frmVoti
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
            this.dgvVoti = new System.Windows.Forms.DataGridView();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVoti
            // 
            this.dgvVoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoti.Location = new System.Drawing.Point(12, 157);
            this.dgvVoti.Name = "dgvVoti";
            this.dgvVoti.Size = new System.Drawing.Size(776, 281);
            this.dgvVoti.TabIndex = 0;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(12, 12);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(134, 23);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(12, 41);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(134, 23);
            this.btnCarica.TabIndex = 2;
            this.btnCarica.Text = "CARICA";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(712, 128);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(75, 23);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // frmVoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvVoti);
            this.Name = "frmVoti";
            this.Text = "frmVoti";
            this.Load += new System.EventHandler(this.frmVoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVoti;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnNuovo;
    }
}