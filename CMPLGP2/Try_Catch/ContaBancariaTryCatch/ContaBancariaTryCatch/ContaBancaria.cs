using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaTryCatch
{
    internal class ContaBancaria
    {
        private double saldoAtual;

        public ContaBancaria()
        {
            saldoAtual = 100.0;
        }

        public double saldo()
        {
            return saldoAtual;
        }

        public void deposito(double valor)
        {


            if (valor >= 50)
            {
                saldoAtual += valor;
                descontaTarifa();
            }
            else
            {
                string textoErro = String.Format("Erro Depósito: O valor mínimo ({0:C}) é de R$50,00", valor);
                throw new ArgumentException(textoErro);
            }
        }

        public void saque(double valor)
        {

            if(valor<10)
            {
                string textoErro = String.Format("Erro Saque: O valor mínimo ({0:C}) é de R$10,00", valor);
                throw new ArgumentException(textoErro);
            }
            if (valor > saldoAtual)
            {
                throw new SaldoInsuficienteException(saldoAtual, valor);
            }

            descontaTarifa();
            saldoAtual -= valor;

        }

        private void descontaTarifa()
        {
            saldoAtual -= 0.1;
        }
    }
}
