using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
     class Aluno
    {
        private string nome;

        private double nota1; // nao pode ser acessado usando o operador ponto

        private double nota2;

        public Aluno(string nome) // construtor, inicializa um objeto qnd ele e criado
        {
            this.nome = nome; // this, diferencia parametro do metodo
            nota1 = 0.0;
            nota2 = 0.0;
        }

        public Aluno(string nome, double nota1, double nota2) // construtor, inicializa um objeto qnd ele e criado
        {
            this.nome = nome; 
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNota1(double n1)// valida a nota
        {
            if (n1>=0 && n1<=10)
            {
                this.nota1 = nota1;
            }
        }

        public double getNota1()
        {
            return nota1;
        }

        public void setNota2(double n2)// valida a nota
        {
            if (n2 >= 0 && n2 <= 10)
            {
                nota2 = n2;
            }
        }

        public double getNota2()
        {
            return nota2;
        }

        public void setNotas(double nota1, double nota2)
        {
            setNota1(nota1);
            setNota2(nota2);
        }
        public double media ()
        {
            double resultado = (nota1 + nota2) / 2.0;

            return resultado;
        }

    }
}
