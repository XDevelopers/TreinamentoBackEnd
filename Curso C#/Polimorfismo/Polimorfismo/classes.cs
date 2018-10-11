using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    abstract class forma_geometrica
    {
        int _largura;
        int _altura;

        public int Largura { get; set; }
        public int Altura {
            get { return _altura; }
            set { _altura = value; }
        }

        public void Apresentar()
        {
            Console.WriteLine("Este método pertence á classe base.");
        }

        //este método terá que ser implementado em todas as classes derivadas
        public abstract void Desenhar();

        public virtual void Desenhar_Outro()
        {
            Console.WriteLine("Método virtual da classe base.");
        }
    }

    class rectangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar rectangulo com as dimensoes: " + Largura + "x" + Altura);
        }

        public override void Desenhar_Outro()
        {
            Console.WriteLine("Este é um método virtual substituido da classe derivada.");
        }
    }

    class triangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar triangulo com as dimensoes: " + Largura + "x" + Altura);
        }
    }

    class circunferencia : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar circunferencia com as dimensoes: " + Largura + "x" + Altura);
        }
    }
}
