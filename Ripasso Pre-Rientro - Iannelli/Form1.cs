using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IannelliFunzioni;

namespace Ripasso_Pre_Rientro___Iannelli
{
    public partial class Form1 : Form
    {
        public string file1 = Iannelli.file1;
        public string file2 = Iannelli.file2;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(file2))
            {
                MessageBox.Show("File presente.");
            }
            else
            {
                MessageBox.Show("File non presente. Caricare un file in ../bin/debug.");
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Azione1_Click(object sender, EventArgs e)
        {
            Iannelli.Azione1();
        }

        private void Azione2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Il numero di campi che compone il record è: {Iannelli.Azione2().ToString()}");
        }

        private void Azione3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La lunghezza massima dei record presenti è: {Iannelli.Azione3().ToString()}");
        }

        private void Azione3Avanzato_Click(object sender, EventArgs e)
        {
            string lungs = "";
            for (int i = 0; i < Iannelli.Azione3Avanzato().Length; i++)
            {
                lungs += Iannelli.Azione3Avanzato()[i] + "\n";
            }

            MessageBox.Show($"La lunghezza massima di ogni campo è: \n{lungs}");
        }
    }
}
