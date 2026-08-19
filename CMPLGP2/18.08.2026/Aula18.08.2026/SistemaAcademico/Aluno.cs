using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
     class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;

        public double calculaMedia() // nn precisa passar por parametro, esta dentro da classe
        { // metodo
            double resultado = (nota1 + nota2) / 2.0;

            return resultado;

        }

    }
}
