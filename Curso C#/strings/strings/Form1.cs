using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //STRINGS

            //string frase = "Este tipo de variavel é alfanumérica";

            //caixa_texto.Text = frase + " (contém " + frase.Length + " letras.)";

            //string frase_maiusculas = frase.ToUpper();
            //string frase_minuscula = frase.ToLower();
            //caixa_texto.Text = frase.Substring(5);
            //caixa_texto.Text = frase.Substring(5, 4);

            //bool resultado = frase.Contains("é");
            //caixa_texto.Text = resultado.ToString();

            //bool resultado = frase.StartsWith("tipo");
            //resultado = frase.EndsWith(".");

            //if (!frase.EndsWith(".")) {
            //    frase = frase + ".";
            //}

            //string frase = "Este tipo de variavel         ";
            //caixa_texto.Text = ">" + frase.Trim() + "<";

            //string frase = "Este tipo de variavel.";
            //int x = frase.IndexOf('E');
            //int y = frase.LastIndexOf('e');
            //caixa_texto.Text = x.ToString() + " " + y.ToString();

            //string nome = "Josiel Matos";
            //string apelido = "Alves ";
            //string nome_completo = nome.Insert(7, apelido);
            //string final = nome.Replace('i', '_');
            //caixa_texto.Text = final;

            string items = "joão,paulo,carlos,manuel,antonio";
            string[] nomes = items.Split(',');
            caixa_texto.Text = nomes[3];
        }
    }
}
