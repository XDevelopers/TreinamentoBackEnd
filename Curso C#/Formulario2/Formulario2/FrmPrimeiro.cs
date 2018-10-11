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
    public partial class FrmPrimeiro : Form
    {
        public FrmPrimeiro()
        {
            InitializeComponent();
        }

        private void cmd_um_Click(object sender, EventArgs e)
        {
            //frmUm formulario = new frmUm(text_nome.Text);
            geral.nome = text_nome.Text;
            frmUm formulario = new frmUm();
            formulario.ShowDialog();
        }

        private void cmd_dois_Click(object sender, EventArgs e)
        {
            frmDois formulario = new frmDois();
            formulario.ShowDialog();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
