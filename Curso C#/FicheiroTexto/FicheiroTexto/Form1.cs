using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FicheiroTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gravar ficheiro de texto
            //int valor = 100;
            //StreamWriter ficheiro = new StreamWriter(@"C:\Users\josiel.alves\Desktop\file.txt", false, Encoding.Default);
            //ficheiro.WriteLine("Primeira frase.");
            //ficheiro.WriteLine("Segunda frase");
            //ficheiro.WriteLine(valor);
            //ficheiro.Dispose();

            StreamWriter ficheiro = new StreamWriter(@"C:\Users\josiel.alves\Desktop\file.txt", true, Encoding.Default);
            ficheiro.WriteLine(textBox1.Text);
            ficheiro.Dispose();

            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\Users\josiel.alves\Desktop\file.txt");
            ficheiro.Dispose();
        }
    }
}
