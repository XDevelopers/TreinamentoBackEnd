using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstanteseEstruturas
{
    public partial class Form1 : Form
    {
        //const string Nome = "Josiel";
        struct estrutura_pessoa
        {
            public string Nome;
            public string Apelido;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("O meu nome é " + Nome);
            normal objeto1 = new normal();
            Console.WriteLine(objeto1.Nome);
            Console.WriteLine(estatica.Nome);

            pessoa p1 = new pessoa();
            p1.Nome = "Josiel";
            p1.Apelido = "Alves";

            estrutura_pessoa p2 = new estrutura_pessoa();
            p2.Nome = "Josiel";
            p2.Apelido = "Alves";
            Console.WriteLine(p2.Nome + " " + p2.Apelido);

            estrutura_pessoa p3 = new estrutura_pessoa() { Nome = "Josiel", Apelido = "Alves" };
            Console.WriteLine(p3.Nome + " " + p3.Apelido);
        }
    }
}
