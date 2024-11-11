using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es01AnrangoRamos
{
    public class clsFile
    {
        private string nomeFile = "";
        private int numeroRighe = 0;
        //
        public string NomeFile
        {
            get => nomeFile;
            set
            {
                nomeFile=Path.Combine(Application.StartupPath, nomeFile + ".txt");
            }
        }

        public int NumeroRighe
        {
            get => numeroRighe; set
            {
                //esentuali controlli che il file estista
                numeroRighe = value;
            }
        }

        public clsFile()
        {

        }
        //metodi
        public List<string> ListaRighe()
        {
            List<string> lstRighe = new List<string>();
            if (NomeFile != "")
            {
                NumeroRighe = 0;
                StreamReader sr = new StreamReader(NomeFile);
                while(sr.Peek()!=-1)
                {
                    lstRighe.Add(sr.ReadLine());
                    NumeroRighe++;
                }
                sr.Close();
            }
            return lstRighe;
        }

        public void salvaModifiche(List<string> l)
        {
            StreamWriter sw = new StreamWriter(NomeFile);
            foreach(string s in l)
                sw.WriteLine(s);
            sw.Close();
        }
        public void aggiungi(string nuovo)
        {
            StreamWriter sw = new StreamWriter(NomeFile,true);
                sw.WriteLine(nuovo);
            sw.Close();
        }
    }
}