using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioReferenciaAbajurLampada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abajur a1 = new Abajur();
            Lampada l1 = new Lampada();

            a1.liga();
            a1.mostraEstado();
            a1.desliga();
            a1.mostraEstado(); //esses comandos executaram "A lampada não esta no abajur" pois a classe abajur não recebeu como parâmetro ainda, fazendo com que o objeto lampada seja null, não podendo assim ser utilizada como objeto para acessar os metodos acende/apaga.

            a1.encaixaLampada(l1);

            a1.mostraEstado();
            a1.liga();
            a1.mostraEstado();
            a1.desliga();
            a1.mostraEstado();
        }
    }
}
