using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaAPP
{
     class ContaBancaria
    {
        private double saldoAtual;
       
        public ContaBancaria()
        {
            saldoAtual = 100.00;
        }
    
        public double getSaldo() // metodo get
        {
            return saldoAtual;
        }

         public bool deposito(double valor)
        {
            if (valor >= 50)
            {
                descontaTarifa();
                saldoAtual += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool saque (double valor)
        {
            if (valor>=10 && saldoAtual>=valor)
            {
                descontaTarifa(); // se a operacao for bem sucedida desconta a tarifa
                saldoAtual -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void descontaTarifa()
        {
            saldoAtual -= 0.10;
        }

    }
}
