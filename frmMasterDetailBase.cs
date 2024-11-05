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

        private bool eseguiFormLoad=false;
        private string nomeFile = "";
        public string NomeFile
        {
            get => nomeFile;
            set
            {
                //esentuali controlli che il file estista
                nomeFile = value;
            }
        }

        public bool EseguiFormLoad { get => eseguiFormLoad; set => eseguiFormLoad = value; }

        public frmMasterDetailBase()
        {
            InitializeComponent();
        }

        private void frmMasterDetailBase_Load(object sender, EventArgs e)
        {
            //questo metodo chiude la form se il file è vuoto
            //si utilizzerà una variabile bool per bypassare il problema
            //problema=Il master detail si apre e si chiude direttamente e ciò spreca risorse del pc
            //correzione non è proprio per quello ma più per la volonta di caricare i dati aperto il form

            //
            if (EseguiFormLoad)
            {


                txt1.ReadOnly = true;

                file.NomeFile = NomeFile;
                list = file.ListaRighe();

                if (file.NumeroRighe > 0) popolaDGV();
                else
                {
                    MessageBox.Show("File vuoto");
                    this.Close();
                }
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

            for (int i = 0; i < riga.Length; i++)
            {
                dgvMaster.Columns[i].SortMode= DataGridViewColumnSortMode.NotSortable;
                dgvMaster.Columns[i].HeaderText = riga[i];
            }
            for (int i = 1; i < file.NumeroRighe; i++)
            {
                riga = list[i].Split(';');
                for (int j = 0; j < riga.Length; j++)
                {
                    dgvMaster.Rows[i - 1].Cells[j].Value = riga[j];
                }
            }
            rigaCorrente = 1;

            impostaTextBox();
        }

        private void impostaTextBox()
        {
            string[] riga = list[rigaCorrente].Split(';');
            txt1.Text = riga[0];
            txt2.Text = riga[1];
            txt3.Text = riga[2];
        }

        private void dgvMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
            rigaCorrente = e.RowIndex + 1;
            impostaTextBox();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string s = "";
            s += txt1.Text +";"+txt2.Text + ";" + txt3.Text;
            list[rigaCorrente] = s;
            file.salvaModifiche(list);
            //RICARICO
            list = file.ListaRighe();
            popolaDGV();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            int idMax = cercaMaxID() + 1;
            string s = "";
            s += idMax + ";" + txt2.Text + ";" + txt3.Text;
            file.aggiungi(s);

            list = file.ListaRighe();
            popolaDGV();
        }

        private int cercaMaxID()
        {
            int id = -1;
            string[] riga;
            for (int i = 1; i < file.NumeroRighe; i++)
            {
                riga = list[i].Split(';');
                if (id < Convert.ToInt32(riga[0])) id = Convert.ToInt32(riga[0]);
            }
            return id;
        }
    }
}
