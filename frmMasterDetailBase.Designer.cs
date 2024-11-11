namespace Es11_MasterDetailEreditato
{
    partial class frmMasterDetailBase
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
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaster
            // 
            this.dgvMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Location = new System.Drawing.Point(2, 1);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.Size = new System.Drawing.Size(776, 302);
            this.dgvMaster.TabIndex = 0;
            this.dgvMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellClick);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.Location = new System.Drawing.Point(9, 335);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(70, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt1.Location = new System.Drawing.Point(85, 335);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(132, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt2.Location = new System.Drawing.Point(85, 371);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 20);
            this.txt2.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl2.Location = new System.Drawing.Point(9, 371);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "label1";
            // 
            // txt3
            // 
            this.txt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt3.Location = new System.Drawing.Point(85, 407);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(132, 20);
            this.txt3.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl3.Location = new System.Drawing.Point(9, 407);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(70, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "label1";
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(542, 335);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(86, 20);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuovo.Location = new System.Drawing.Point(542, 367);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(86, 20);
            this.btnNuovo.TabIndex = 8;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // frmMasterDetailBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvMaster);
            this.Name = "frmMasterDetailBase";
            this.Text = "frmMasterDetailBase";
            this.Load += new System.EventHandler(this.frmMasterDetailBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNuovo;
        protected System.Windows.Forms.TextBox txt1;
        protected System.Windows.Forms.TextBox txt2;
        protected System.Windows.Forms.TextBox txt3;
    }
}