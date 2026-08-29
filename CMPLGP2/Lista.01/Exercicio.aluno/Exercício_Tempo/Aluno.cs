using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Tempo
{
    internal class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;

        public double CalculaMedia()
        {
            return (nota1 + nota2) / 2;
        }

    }
}
