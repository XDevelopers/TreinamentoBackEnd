using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamposPropriedades
{
    class teste
    {
        //Definição de um CAMPO
        string _nome;
        int _idade;

        //definição de uma PROPRIEDADE
        //public string Nome {
        //    set {_nome = value;}
        //    get {return _nome;}
        //}
        public string Nome { get; set; }

        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(Nome);
        }
    }
}
