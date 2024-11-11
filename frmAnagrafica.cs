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
    public partial class frmAnagrafica : frmMasterDetailBase
    {
        public frmAnagrafica()
        {
            InitializeComponent();
        }

        private void btnVediVoti_Click(object sender, EventArgs e)
        {
            frmVoti f=new frmVoti();
            f.IdAlunno = txt1.Text;
            f.NomeAlunno = txt2.Text;
            f.CognomeAlunno = txt3.Text;
            f.ShowDialog();
        }
    }
}
