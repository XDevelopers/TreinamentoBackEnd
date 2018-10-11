using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mmu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mmu_open.Enabled = false;

            

        }

        private void mmu_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void propetiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar opções ao combo do menu
            mmu_combo_1.Items.Add("Valor 1");
            mmu_combo_1.Items.Add("Valor 2");
            mmu_combo_1.Items.Add("Valor 3");
            mmu_combo_1.Items.Add("Valor 4");
            mmu_combo_1.Items.Add("Valor 5");
        }

        private void mmu_combo_1_Click(object sender, EventArgs e)
        {
            label_resultado.Text = mmu_combo_1.Text;
        }

        private void mmu_combo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mmu_combo_1.Text == "Valor 1")
                MessageBox.Show("OK");
            label_resultado.Text = mmu_combo_1.Text;
        }
    }
}
