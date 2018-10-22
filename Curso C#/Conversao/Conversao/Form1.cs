using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\Users\josiel.alves\Desktop\dados.txt", false, Encoding.Default);
            //string
            ficheiro.WriteLine("Esta frase é alfanumérica.");

            //int
            int valor = 150;
            ficheiro.WriteLine(valor);

            //boleano
            bool resultado = false;
            ficheiro.WriteLine(resultado);

            //Data
            ficheiro.WriteLine(DateTime.Now);

            //cor
            Color cor = Color.FromArgb(30, 125, 232);
            ficheiro.WriteLine(cor.ToArgb());

            ficheiro.Dispose();
        }

        private void cmd_ler_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\Users\josiel.alves\Desktop\dados.txt", Encoding.Default);
            //string
            string a = ficheiro.ReadLine();
            //int
            int b = int.Parse(ficheiro.ReadLine());
            //boleano
            bool c = bool.Parse(ficheiro.ReadLine());
            //data
            DateTime d = DateTime.Parse(ficheiro.ReadLine());

            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));
            pictureBox1.BackColor = cor;
            ficheiro.Dispose();
        }
    }
}
