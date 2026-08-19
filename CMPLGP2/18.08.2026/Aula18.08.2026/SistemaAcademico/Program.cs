using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
     class Program
    {
        static void Main(string[] args)
        {
         Aluno qualquernome = new Aluno(); // new cria o objeto

            qualquernome.nome = "Jonatas";
            qualquernome.nota1 = 7.5;
            qualquernome.nota2 = 9.2;
            double rs = qualquernome.calculaMedia();

            Console.WriteLine("Média: {0}", rs);

            
         //Aluno qualquernome2 = new Aluno(); new cria o objeto
        }
    }
}
