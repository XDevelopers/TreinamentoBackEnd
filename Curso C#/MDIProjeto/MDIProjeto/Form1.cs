using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIProjeto
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmUm f = new frmUm(this);
            f.Show();
        }

        private void mnu_abrir_Click(object sender, EventArgs e)
        {
            frmUm f = new frmUm(this);
            f.Show();
        }
    }
}
