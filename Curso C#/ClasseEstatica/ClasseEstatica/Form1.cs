using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = estatica.NomePrograma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal objeto1 = new normal();
            objeto1.Nome = "Josiel Alves";
            objeto1.ApresentarNome();

            normal objeto2 = new normal();
            objeto2.Nome = "Alves Josiel";
            objeto2.ApresentarNome();

            estatica.Nome = "Josiel";
            //estatica.ApresentarNome();

            estatica.Nome = "Carlos";
            estatica.ApresentarNome();
        }
    }
}
