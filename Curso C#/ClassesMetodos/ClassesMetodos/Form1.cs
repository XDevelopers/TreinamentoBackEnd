using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            cl_matematica calculadora = new cl_matematica();

            //int resultado = calculadora.Adicao(10, 20);
            //int resultado = calculadora.Subtracao(100, 50);
            //int resultado = calculadora.Multiplicacao(20, 5);
            //int resultado = calculadora.Divisao(1000, 10);
            //caixa_texto.Text = resultado.ToString();

            int resultado = calculadora.Operacoes(10, 5, "adicao");
            caixa_texto.Text = resultado.ToString();
        }
    }
}
