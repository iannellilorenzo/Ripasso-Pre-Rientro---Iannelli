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
        public string file1 = @"iannelli1.csv";
        public string file2 = @"iannelli.csv";

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
    }
}
