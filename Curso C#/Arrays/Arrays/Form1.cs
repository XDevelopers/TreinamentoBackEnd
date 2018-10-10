using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //NAS COLEÇÕES, O ÍNDICE COMEÇA EM 0 <<<<<------
            //ARRAYS

            //int[] valores;
            //valores = new int[5];

            //valores[0] = 10;
            //valores[1] = 20;
            //valores[2] = 30;
            //valores[3] = 40;
            //valores[4] = 50;

            //int[] valores = new int[5];

            int[] valores = new int[] {
                10, 20, 30, 40, 50, 60, 70, 10
            };

            for(int indice = 0; indice < valores.Length; indice++) {
                lista.Items.Add(valores[indice]);
            }

            //foreach(int valor in valores) {
            //    lista.Items.Add(valor);
            //}
        }
    }
}
