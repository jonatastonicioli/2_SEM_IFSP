using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tempo t0 = new Tempo(); // cai no construtor 1

            t0.setHora(23);
            t0.setMinuto(30);
            t0.setSegundo(12);

            t0.imprimeTempoSimples();
            t0.imprimeTempoExtenso();

            //t0.setHora(25); , da erro pela validação do set na classe
            //Console.WriteLine(t0.getHora());

            Tempo t1 = new Tempo(12, 30, 25); //cai no construtor 2
            // assumindo que os valores passados como parametros estão corretos
            // se os valores fossem incorretos, dava para usar os setter no construtor para validar


            t1.setHora(25);
            t1.setMinuto(25);
            t1.setSegundo(50);

            t1.imprimeTempoSimples();
            t1.imprimeTempoExtenso();

        }
    }
}
