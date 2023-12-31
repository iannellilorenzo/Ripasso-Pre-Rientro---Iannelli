﻿using System;
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
                Iannelli.Azione1();
                Iannelli.Azione4();
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

        private void Azione5_Click(object sender, EventArgs e)
        {
            bool azione5 = Iannelli.Azione5(NomeZona.Text, Attuazione.Text, Data.Text, TipoSosta.Text);

            if (azione5)
            {
                MessageBox.Show("Azione eseguita correttamente.");
            }
            else
            {
                MessageBox.Show("Compilare i campi correttamente.");
            }
        }

        private void Azione6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Iannelli.Azione6().Length; i++)
            {
                listView1.Items.Add(Iannelli.Azione6()[i]);
            }
        }

        private void Azione7_Click(object sender, EventArgs e)
        {
            if (Iannelli.Azione7(Ricerca.Text) == -2)
            {
                MessageBox.Show("Compilare correttamente i campi.");
            }
            else if (Iannelli.Azione7(Ricerca.Text) == -1)
            {
                MessageBox.Show("Elemento corrispondente all'ID inserito inesistente.");
            }
            else
            {
                MessageBox.Show($"Elemento corrispondente trovato all'ID: {Iannelli.Azione7(Ricerca.Text)}");
            }
        }

        private void Azione8_Click(object sender, EventArgs e)
        {
            if (Iannelli.Azione8(NomeZona.Text, Attuazione.Text, Data.Text, TipoSosta.Text, Ricerca.Text) == -2)
            {
                MessageBox.Show("Compilare correttamente i campi");
            }
            else if (Iannelli.Azione8(NomeZona.Text, Attuazione.Text, Data.Text, TipoSosta.Text, Ricerca.Text) == -1)
            {
                MessageBox.Show("Elemento corrispondente all'ID inserito inesistente.");
            }
            else
            {
                MessageBox.Show("Azione eseguita correttamente");
            }
        }

        private void Azione9_Click(object sender, EventArgs e)
        {
            Iannelli.Azione9(Ricerca.Text);
        }
    }
}
