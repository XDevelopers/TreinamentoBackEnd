using System;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            ////Colocar comentario ao meu código
            ////segundo
            ////terceiro

            //caixa_texto.Text = "Olá, Mundo!";

            ///*
            // Comentario
            // Em 
            // Bloco
            // */

            //#region regiao 1
            //caixa_texto.Text = "Olá, Mundo!";
            //caixa_texto.Text = "Olá, Mundo!";
            //caixa_texto.Text = "Olá, Mundo!";
            //caixa_texto.Text = "Olá, Mundo!";
            //caixa_texto.Text = "Olá, Mundo!";
            //#endregion

            //System.Windows.Forms.Application.Exit();

            //criar variavel - tipo
            //string nome = "Josiel Alves";
            //int idade = 24;
            //int segunda_idade = 10;

            //int idade_total = idade + segunda_idade;

            //caixa_texto.Text = idade_total.ToString();
            //caixa_texto.Text = nome;
            //caixa_texto.Text = valor.ToString();

            //int valor_inicial = 1000;
            //int valor_adicional = 500;
            //valor_inicial = 2000;
            //valor_inicial = valor_inicial + 100;
            //valor_inicial = valor_adicional;
            //caixa_texto.Text = "Eu tenho o seguinte valor: " + valor_inicial.ToString();

            //string nome = "Josiel";
            //string apelido = "Alves";
            //int idade = 24;
            //caixa_texto.Text = "O meu nome é " + nome + " " + apelido + " e tenho " + idade.ToString() + " anos de idade.";

            //NUMÉRICAS

            ////byte = 0 to 255
            //byte idade = 24;

            ////short = -32.768 to 32.767
            //short idade2 = 24;

            //// inteiro - (int) - -2.147.483.648 to 2.147.483.647
            //int idade_planeta = 234982347;

            ////long = -9.223.372.036.854.775.808 to 9.223.372.036.854.775.808
            //long valor_enorme = 3245683746354;

            //// COM CASAS DECIMAIS

            //float valor1 = 10.5f;
            //double valor2 = 20.3;
            //decimal valor3 = 30.7m;

            //double resultado = (double) 1 / 3;
            //double parcela1 = 1;
            //double parcela2 = 3;
            //resultado = parcela1 / parcela2;

            //caixa_texto.Text = resultado.ToString();

            //ALFANUMERICAS
            //string nome = "Josiel Alves " + 148 + 65;
            //int p1 = 20;
            //int p2 = 30;
            //string resultado = p1.ToString() + " + " + p2.ToString() + " = " + (p1 + p2);

            //caixa_texto.Text = resultado;

            string resultado = "Josiel Alves";
            int numero_caracteres = resultado.Length;
            caixa_texto.Text = numero_caracteres.ToString();

            char caracter1 = 'a';
            char caracter2 = 'b';
            caixa_texto.Text = caracter1.ToString() + caracter2.ToString();

            bool decisao = true;

        }
    }
}
