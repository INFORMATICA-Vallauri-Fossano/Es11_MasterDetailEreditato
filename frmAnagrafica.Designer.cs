namespace Es11_MasterDetailEreditato
{
    partial class frmAnagrafica
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
            this.btnVediVoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVediVoti
            // 
            this.btnVediVoti.Location = new System.Drawing.Point(679, 362);
            this.btnVediVoti.Name = "btnVediVoti";
            this.btnVediVoti.Size = new System.Drawing.Size(75, 23);
            this.btnVediVoti.TabIndex = 10;
            this.btnVediVoti.Text = "VEDI VOTI";
            this.btnVediVoti.UseVisualStyleBackColor = true;
            this.btnVediVoti.Click += new System.EventHandler(this.btnVediVoti_Click);
            // 
            // frmAnagrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVediVoti);
            this.Name = "frmAnagrafica";
            this.Text = "frmAnagrafica";
            this.Controls.SetChildIndex(this.btnVediVoti, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVediVoti;
    }
}