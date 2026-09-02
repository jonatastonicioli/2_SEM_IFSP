using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador obj1 = null;
            obj1 = new Contador();

            Contador obj2 = null;
            obj2 = obj1;

            obj1.incrementa(5);
            obj2.imprime();

            obj2.incrementa(10);
            obj1.imprime();

        }
    }
}
