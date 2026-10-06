using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_01__Cofrinho_
{
    internal class Moeda
    {
        private double valor;

        public Moeda()
        {
            valor = 1;
        }

        public bool setValor(double valor)
        {
            if (valor == 1 || valor == 0.5 || valor ==0.25 || valor == 0.1 || valor == 0.01)
            {
                this.valor = valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getValor()
        {
            return valor;
        }
    }
}
