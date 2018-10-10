using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //lista.Items.Add(1);
            //lista.Items.Add(2);

            //FOR

            //for(int valor = 1; valor <= 100; valor+=2) {
            //    lista.Items.Add(valor);
            //}

            //WHILE
            //int vezes = 0;
            //while (vezes <= 100) {
            //    lista.Items.Add(vezes);
            //    vezes++;
            //}

            //DO WHILE
            //int vezes = 0;
            //do {
            //    lista.Items.Add(vezes);
            //    vezes++;
            //} while (vezes <= 100);

            //FOREACH

            string frase = "Este ciclo é fantástico.";

            List<string> lista_nomes = new List<string>() {
                "Joao", "antonio", "Pedro", "josiel"
            };

            foreach(string s in lista_nomes) {
                lista.Items.Add(s);
            }
        }
    }
}
