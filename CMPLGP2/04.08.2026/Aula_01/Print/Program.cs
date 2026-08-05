using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 2500;

            Console.WriteLine("Número: {0:C}", numero); // saida em moeda
            Console.WriteLine("Número: {0:D5}", 25); // saida em decimal
        }
    }
}
