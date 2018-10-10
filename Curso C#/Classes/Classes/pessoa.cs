using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class pessoa
    {

        //public string nome;
        //public int idade;
        //public string cor_cabelo;

        //public void Falar()
        //{
        //    System.Windows.Forms.MessageBox.Show("Olá, o meu nome é " + nome);
        //}

        //public void Apresentar_se()
        //{
        //    System.Windows.Forms.MessageBox.Show("O meu nome é " + nome + " e tenho " + idade + " anos");
        //}

        //public void Falar()
        //{
        //    System.Windows.Forms.MessageBox.Show("Falar.");
        //}

        //public void Correr()
        //{
        //    System.Windows.Forms.MessageBox.Show("Correr.");
        //    Saltar();
        //}

        //private void Saltar()
        //{
        //    System.Windows.Forms.MessageBox.Show("Saltar.");
        //}

        public string nome;
        public string apelido;

        public void IdentificarSe()
        {
            System.Windows.Forms.MessageBox.Show(ConstruirNome());
        }

        private string ConstruirNome()
        {
            string nome_completo = nome + " " + apelido;
            return nome_completo;
        }
    }
}
