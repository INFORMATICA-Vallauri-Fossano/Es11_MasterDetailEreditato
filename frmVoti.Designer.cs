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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVoti
            // 
            this.dgvVoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoti.Location = new System.Drawing.Point(12, 12);
            this.dgvVoti.Name = "dgvVoti";
            this.dgvVoti.Size = new System.Drawing.Size(303, 426);
            this.dgvVoti.TabIndex = 0;
            // 
            // frmVoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVoti);
            this.Name = "frmVoti";
            this.Text = "frmVoti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVoti;
    }
}