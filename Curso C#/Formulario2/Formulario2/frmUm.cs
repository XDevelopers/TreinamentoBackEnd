using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario2
{
    public partial class frmUm : Form
    {
        //string valor;

        //public frmUm(string valor_nome)
        public frmUm()
        {
            InitializeComponent();
            //valor = valor_nome;
            //label_resultado_final.Text = valor;
            label_resultado_final.Text = geral.nome;
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fecha este formulario
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label_outra.Text = valor;
            label_outra.Text = geral.nome;
        }
    }
}
