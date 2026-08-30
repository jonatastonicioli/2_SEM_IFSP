using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Data
{
    internal class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data () // construtor sem parametro
        {
            dia = 01;
            mes = 01;
            ano = 1970;
        }

        public void setData (int dia, int mes, int ano) //apenas um set mandando os tre parametros
        {
            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 30 }; // armazenando os dias em um array para nao ter q fazer um if para cada caso
            if (mes>=1 && mes<=12)
            {
                this.mes = mes;

                if (dia <= diasPorMes[mes - 1] && dia > 0) // só faz a verificação do dia, se a verificação do mes vor válida, por isso está dentro do if do mes
                {
                    this.dia = dia;
                }
                else
                {
                    Console.WriteLine("A quantidade de dias não é correta para o mês indicado");
                }
            }
            else
            {
                Console.WriteLine("Digite um mês válido");
            }

            if(ano>= 0 && ano<=2063)
            {
                this.ano = ano;
            }
            else
            {
                Console.WriteLine("Digite um ano válido");
            }
        }
        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }
        public int getAno()
        {
            return ano;
        }

        public void imprimeDataSimples()
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
        }

        public void imprimeDataExtenso()
        {
            string[] mesExtenso = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            Console.WriteLine("{0:D2} de {1} de {2}", dia, mesExtenso[mes - 1], ano);
        }
    }
}
