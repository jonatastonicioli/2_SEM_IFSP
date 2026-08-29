using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno ficha = new Aluno(); // criação objeto

            ficha.nome = "Jônatas";
            ficha.nota1 = 10;
            ficha.nota2 = 5;

            double resultado = ficha.CalculaMedia();




            Console.WriteLine("O nome do aluno é: {0}", ficha.nome);
            Console.WriteLine("A média é: {0}", resultado);
        }
    }
}
