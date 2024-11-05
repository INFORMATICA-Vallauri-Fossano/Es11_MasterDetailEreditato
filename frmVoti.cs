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
        private static Random rnd=new Random();

        public double Storia { get => storia; set => storia = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Matematica { get => matematica; set => matematica = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Sistemi { get => sistemi; set => sistemi = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Cybersecurity { get => cybersecurity; set => cybersecurity = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Russo { get => russo; set => russo = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Inglese { get => inglese; set => inglese = rnd.Next(11)*0.1+rnd.Next(10); }
        public double Informatica { get => informatica; set => informatica = rnd.Next(11)*0.1+rnd.Next(10); }

    }
}
