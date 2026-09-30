using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questao._01
{
    internal class Triangulo
    {
        private double lado1;
        private double lado2;

        private double lado3;

        public Triangulo ()
        {
            lado1 = 1.0;
            lado2 = 1.0;
            lado3 = 1.0;
        }

       public double getLado1()
        {
            return lado1;
        }

        public double getLado2()
        {
            return lado2;
        }
        public double getLado3()
        {
            return lado3;
        }

        public void setLados(double lado1, double lado2, double lado3)
        {
            if (lado1 < 1 || lado2 < 1 || lado3< 1)
            {
                Console.WriteLine("Digite valores maiores que um");
            }else if (lado1 + lado2 > lado3 && lado2+lado3>lado1 && lado1 + lado3 > lado2)
            {
                //Console.WriteLine("Os lados formam um triângulo");
                this.lado1 = lado1;
                this.lado2 = lado2;
                this.lado3 = lado3;

    
            }
            else
            {
                //Console.WriteLine("Os lados não formam um triângulo");
            }

        }

        public string tipo()
        {
            if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3)
            {
                return "Equilátero";
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            { 
                return "Escaleno";
            }
            else
            {
                return "Isósceles";
            }
        


            
        }

    }
}
