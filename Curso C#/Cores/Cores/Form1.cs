using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //caixa.BackColor = Color.Green;
            //caixa.BackColor = Color.FromArgb(255, 0, 0);

            /*
             * alpha - 0 -> 255
             * red, green, blue - 0 a 255
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApresentarCor();
        }

        private void ApresentarCor()
        {
            cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            caixa.BackColor = cor;

            label_exemplo.Text = "RGB(" + trackBar1.Value + ";" +
                                        trackBar2.Value + ";" +
                                        trackBar3.Value + ")";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            ApresentarCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            ApresentarCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            ApresentarCor();
        }
    }
}
