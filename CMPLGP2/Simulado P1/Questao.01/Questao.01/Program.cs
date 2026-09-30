using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            Triangulo triangulo2 = new Triangulo();
            Triangulo triangulo3 = new Triangulo();

            triangulo1.setLados(5, 5, 5);
            triangulo2.setLados(7, 7, 5);
            triangulo3.setLados(6, 9, 12);

            Console.WriteLine("Triângulo 1: ({0}, {1}, {2}) - {3}", triangulo1.getLado1(), triangulo1.getLado2(), triangulo1.getLado3(), triangulo1.tipo());
            Console.WriteLine("Triângulo 2: ({0}, {1}, {2}) - {3}", triangulo2.getLado1(), triangulo2.getLado2(), triangulo2.getLado3(), triangulo2.tipo());
            Console.WriteLine("Triângulo 3: ({0}, {1}, {2}) - {3}", triangulo3.getLado1(), triangulo3.getLado2(), triangulo3.getLado3(), triangulo3.tipo());
        }
    }
}


