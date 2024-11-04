using Es01AnrangoRamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_MasterDetailEreditato
{
    public partial class frmMasterDetailBase : Form
    {
        private clsFile file = new clsFile();
        private List<string> list;
        private int rigaCorrente = 0;

        private string nomeFile = "anagrafica.txt";
        public string NomeFile
        {
            get => nomeFile;
            set
            {
                //esentuali controlli che il file estista
                nomeFile = value;
            }
        }
        public frmMasterDetailBase()
        {
            InitializeComponent();
        }

        private void frmMasterDetailBase_Load(object sender, EventArgs e)
        {
            file.NomeFile =Application.StartupPath+@"\"+NomeFile;
            list = file.ListaRighe();
            if (file.NumeroRighe > 0) popolaDGV();
            else
            {
                MessageBox.Show("File vuoto");
                this.Close();
            }
        }

        private void popolaDGV()
        {
            //imposto le label
            string[] riga = list[0].Split(';');
            lbl1.Text = riga[0];
            lbl2.Text = riga[1];
            lbl3.Text = riga[2];
            //imposto intestazione dgv
            dgvMaster.AllowUserToAddRows = false;
            dgvMaster.AllowUserToDeleteRows = false;    
            dgvMaster.ReadOnly= true;
            dgvMaster.AllowUserToResizeColumns=false;
            dgvMaster.ColumnCount=riga.Length;
            dgvMaster.RowCount = file.NumeroRighe - 1;
            dgvMaster.ColumnHeadersVisible= true;
        }
    }
}
