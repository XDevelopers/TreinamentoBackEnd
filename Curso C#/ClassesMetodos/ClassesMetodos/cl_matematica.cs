using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMetodos
{
    class cl_matematica
    {
        //public int Adicao(int parcela1, int parcela2)
        //{
        //    return parcela1 + parcela2;
        //}

        //public int Subtracao(int parcela1, int parcela2)
        //{
        //    return parcela1 - parcela2;
        //}

        //public int Multiplicacao(int parcela1, int parcela2)
        //{
        //    return parcela1 * parcela2;
        //}

        //public int Divisao(int parcela1, int parcela2)
        //{
        //    return parcela1 / parcela2;
        //}

        int parcela1;
        int parcela2;

        public int Operacoes(int parcela1, int parcela2, string operacao)
        {
            int resultado = -1;
            //switch (operacao) {
            //    case "adicao":
            //        resultado = parcela1 + parcela2;
            //        break;
            //    case "subtracao":
            //        resultado = parcela1 - parcela2;
            //        break;
            //    case "multiplicacao":
            //        resultado = parcela1 * parcela2;
            //        break;
            //    case "divisao":
            //        resultado = parcela1 / parcela2;
            //        break;
            //    default:
            //        resultado = -1000;
            //        break;
            //}

            //if (operacao == "adicao")
            //    resultado = parcela1 + parcela2;
            //else if(operacao == "subtracao")
            //    resultado = parcela1 - parcela2;
            //else if(operacao == "multiplicacao")
            //    resultado = parcela1 * parcela2;
            //else if(operacao == "divisao")
            //    resultado = parcela1 / parcela2;

            this.parcela1 = parcela1;
            this.parcela2 = parcela2;

            if (operacao == "adicao")
                resultado = adicao();
            else if (operacao == "subtracao")
                resultado = subtracao();
            else if (operacao == "multiplicacao")
                resultado = multiplicacao();
            else if (operacao == "divisao")
                resultado = divisao();

            return resultado;
        }

        private int adicao()
        {
            return parcela1 + parcela2;
        }

        private int subtracao()
        {
            return parcela1 - parcela2;
        }

        private int multiplicacao()
        {
            return parcela1 * parcela2;
        }

        private int divisao()
        {
            return parcela1 / parcela2;
        }
    }
}
