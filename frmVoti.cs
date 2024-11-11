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

    public partial class frmVoti : Form
    {
        public frmVoti()
        {
            InitializeComponent();
        }
        List<recordVotiStudente> voti=new List<recordVotiStudente>();
        private void frmVoti_Load(object sender, EventArgs e)
        {

            fileManager.NomeFile = "voti";

        }
        clsFile fileManager = new clsFile();

        private string idAlunno;
        public string IdAlunno { get => idAlunno; set => idAlunno = value; }
        public string NomeAlunno { get => nomeAlunno; set => nomeAlunno = value; }
        public string CognomeAlunno { get => cognomeAlunno; set => cognomeAlunno = value; }

        private string nomeAlunno;
        private string cognomeAlunno;
        private void btnCarica_Click(object sender, EventArgs e)
        {
            List<string> data = fileManager.ListaRighe();
            for (int i = 0; i < data.Count; i++)
            {
                voti.Add(new recordVotiStudente(data[i].Split(';')));
            }

            dgvVoti.DataSource = null;
            dgvVoti.DataSource = voti;
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            voti.Add(new recordVotiStudente());
        }
    }
    public class recordVotiStudente
    {
        private double storia;
        private double matematica;
        private double sistemi;
        private double cybersecurity;
        private double russo;
        private double inglese;
        private double informatica;
        private static Random rnd = new Random();
        public recordVotiStudente(string[] data)
        {
            storia =Convert.ToDouble( data[0]);
            matematica =Convert.ToDouble( data[1]);
            sistemi =Convert.ToDouble( data[2]);
            cybersecurity =Convert.ToDouble( data[3]);
            russo =Convert.ToDouble( data[4]);
            inglese =Convert.ToDouble( data[5]);
            informatica =Convert.ToDouble( data[6]);
        }

        public recordVotiStudente()
        {
            storia = rnd.Next(11) * 0.1 + rnd.Next(10);
            matematica = rnd.Next(11) * 0.1 + rnd.Next(10);
            sistemi = rnd.Next(11) * 0.1 + rnd.Next(10);
            russo = rnd.Next(11) * 0.1 + rnd.Next(10);
            inglese = rnd.Next(11) * 0.1 + rnd.Next(10);
            cybersecurity = rnd.Next(11) * 0.1 + rnd.Next(10);
            informatica = rnd.Next(11) * 0.1 + rnd.Next(10);
        }

        public string Storia { get => storia.ToString("N2"); }
        public string Matematica { get => matematica.ToString("N2"); }
        public string Sistemi { get => sistemi.ToString("N2"); }
        public string Cybersecurity { get => cybersecurity.ToString("N2"); }
        public string Russo { get => russo.ToString("N2"); }
        public string Inglese { get => inglese.ToString("N2"); }
        public string Informatica { get => informatica.ToString("N2"); }

    }
}
