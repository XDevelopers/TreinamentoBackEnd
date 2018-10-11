using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herenca
{
    class cl_carro : cl_veiculo
    {
        public int velocidade_maxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("O carro Acelerou");
        }

        public void LigarMotor()
        {

        }

        public override void Parar()
        {
            Console.WriteLine("Paragem do carro.");
        }

    }
}
