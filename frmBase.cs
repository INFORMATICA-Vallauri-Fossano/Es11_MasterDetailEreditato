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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void btnAnagrafica_Click(object sender, EventArgs e)
        {
            frmAnagrafica f=new frmAnagrafica();
            f.Text = "FORM DELL'ANAGRAFICA";
            f.NomeFile = Application.StartupPath + @"\" + "anagrafica.txt";
            f.EseguiFormLoad = true;
            f.ShowDialog();

        }

        private void btnClassi_Click(object sender, EventArgs e)
        {
            frmClassi f = new frmClassi();
            f.Text = "FORM DELLE CLASSI";
            f.EseguiFormLoad = true;
            f.NomeFile = Application.StartupPath + @"\" + "classi.txt";
            f.ShowDialog();
        }
    }
}
