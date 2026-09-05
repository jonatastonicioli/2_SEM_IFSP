using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Salario
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBase;

        private double qtdHorasExtras;
        private double valorHorasExtras;

        public Funcionario()
        {
            nome = "";
            salarioBase = 0.0;
            qtdHorasExtras = 0.0;
            valorHorasExtras = 0.0;
        }

        public Funcionario (string nome, double salarioBase, double qtdHorasExtras, double valorHorasExtras)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
            this.qtdHorasExtras = qtdHorasExtras;
            this.valorHorasExtras = valorHorasExtras;
        }

        public void setSalario(double salarioBase)
        {
            if (salarioBase < 954)
            {
                Console.WriteLine("O salario base deve ser maior que 954");
            }
            else
            {
                this.salarioBase = salarioBase;
            }
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
            
           



        public void setHoras(double qtdHorasExtras)
        {
            if (qtdHorasExtras > 10)
            {
                Console.WriteLine("A quantidade de horas extras não pode exceder 10");
            }
            else
            {
                this.qtdHorasExtras = qtdHorasExtras;
            }
        }

        public void setValor(double valorHorasExtras)
        {
            if (valorHorasExtras < 10)
            {
                Console.WriteLine("O valor de cada hora extra deve ser de pelo menos R$ 10,00");
            }
            else
            {
                this.valorHorasExtras = valorHorasExtras;
            }


        }
        public double calcularSalario()
        {
            return salarioBase + (qtdHorasExtras * valorHorasExtras);
        }

        public string getNome() // metodos gets sao sem parametro mas com retorno
        {
            return nome;
        }

        public double getSalario()
        {
            return salarioBase;
        }

        public double getHorasExtras()
        {
            return qtdHorasExtras;
        }
        public double getValorHoras()
        {
            return valorHorasExtras;
        }




        public void gerarRelatorio()
        {

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Nome: {0}", getNome());
            Console.WriteLine("Salario base: {0}", getSalario());
            Console.WriteLine("Quantidade de horas extras: {0}", getHorasExtras());
            Console.WriteLine("Valor das horas extras: {0}", getValorHoras());
            Console.WriteLine("O salário final é: {0}", calcularSalario());


        }
    }
}
