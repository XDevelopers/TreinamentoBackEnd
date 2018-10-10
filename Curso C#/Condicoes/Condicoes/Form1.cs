using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //IF

            //int valor = 20;
            //if (valor == 2)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor < 30)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor > 30)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor >= 20)
            //{
            //    label_resultado.Text = "OK";
            //}
            //if (valor <= 20)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor != 20)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor == 20 || valor == 30)
            //{
            //    label_resultado.Text = "OK";
            //}

            //if (valor == 20 && (valor + 5) > 13)
            //{
            //    label_resultado.Text = "OK";
            //}
            //if (valor > 10)
            //{
            //    label_resultado.Text = "SIM";
            //}
            //else
            //{
            //    label_resultado.Text = "NÃO";
            //}
            //if(valor < 5) {
            //    label_resultado.Text = "Valor < 5";
            //} else if(valor < 10) {
            //    label_resultado.Text = "Valor < 10";
            //} else if(valor < 15) {
            //    label_resultado.Text = "Valor < 15";
            //} else {
            //    label_resultado.Text = "Não deu!";
            //}

            //SWITCH

            //int valor = 20;

            //switch (valor) {
            //    case 10:
            //        label_resultado.Text = "Primeira Opção";
            //        break;
            //    case 20:
            //        label_resultado.Text = "Segunda Opção";
            //        break;
            //    default:
            //        label_resultado.Text = "Nenhum resultado";
            //        break;
            //}

            //Operador Ternário

            int valor = 10;

            if(valor == 10) {
                label_resultado.Text = "SIM";
            } else {
                label_resultado.Text = "NÃO";
            }

            label_resultado.Text = valor == 10 ? "SIM" : "NÃO";
        }
    }
}
