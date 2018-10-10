using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nome = "asdfasdf";
            //pessoa p1 = new pessoa();
            //p1.nome = "Josiel";
            //p1.idade = 24;
            //p1.cor_cabelo = "Castanho";

            //p1.Falar();
            //p1.Apresentar_se();

            //pessoa p2 = new pessoa();
            //p2.nome = "Carlos";
            //p2.idade = 10;
            //p2.cor_cabelo = "Amarelo";

            ////p2.Falar();
            //label1.Text = p1.nome;

            //pessoa p1 = new pessoa();
            //p1.Falar();
            //p1.Correr();

            pessoa p1 = new pessoa();
            p1.nome = "Josiel";
            p1.apelido = "Alves";

            //identificar-se
            p1.IdentificarSe();
        }
    }
}
