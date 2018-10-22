using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ApagarPastasFicheiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Copia arquivo
            //File.Copy(@"C:\Users\josiel.alves\Desktop\dados.txt", @"C:\Users\josiel.alves\Desktop\temp\dados.txt");

            //Move arquivo
            //File.Move(@"C:\Users\josiel.alves\Desktop\dados.txt", @"C:\Users\josiel.alves\Desktop\temp\dados.txt");

            //Move uma lista de arquivos
            //string[] lista_ficheiros = Directory.GetFiles(@"C:\Users\josiel.alves\Desktop\", "*.txt");

            //foreach (string ficheiro in lista_ficheiros) {
            //    listBox1.Items.Add(ficheiro);
            //    File.Move(ficheiro, @"C:\Users\josiel.alves\Desktop\temp\" + Path.GetFileName(ficheiro));
            //}

            ////Apaga um arquivo
            //File.Delete(@"C:\Users\josiel.alves\Desktop\dados.txt");

            ////Apaga uma pasta
            //if (Directory.Exists(@"C:\Users\josiel.alves\Desktop\temp")){ 
            //    Directory.Delete(@"C:\Users\josiel.alves\Desktop\temp", true);


            string[] ficheiros = Directory.GetFiles(@"C:\Users\josiel.alves\Desktop\dados", "*.jpg");

            listBox1.Items.AddRange(ficheiros);


            MessageBox.Show("Terminou");
        }
    }
}
