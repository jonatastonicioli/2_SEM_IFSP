using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaTryCatch
{
    internal class SaldoInsuficienteException : Exception // classe do tipo exceção tem que por : Exception, so pode usar throw em classes que sao exceç~eso
    {
        private double saldoAtual;
        private double valorSaque;

        public SaldoInsuficienteException(double saldoAtual, double valorSaque)
        {
            this.saldoAtual = saldoAtual;
            this.valorSaque = valorSaque;
        }

        public double getSaldoAtual()
        {
            return saldoAtual;
        }

        public double getValorSaque()
        {
            return valorSaque;
        }

    }
}
