using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_01dnv
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

            Console.WriteLine("Triângulo 1: ({0}, {1}, {2}) - {3}", triangulo1.getlado1(), triangulo1.getlado2(), triangulo1.getlado3(), triangulo1.tipo());
            Console.WriteLine("Triângulo 2: ({0}, {1}, {2}) - {3}", triangulo2.getlado1(), triangulo2.getlado2(), triangulo2.getlado3(), triangulo2.tipo());
            Console.WriteLine("Triângulo 3: ({0}, {1}, {2}) - {3}", triangulo3.getlado1(), triangulo3.getlado2(), triangulo3.getlado3(), triangulo3.tipo());
            
        }
    }
}
