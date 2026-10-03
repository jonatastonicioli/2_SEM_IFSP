using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_01dnv
{
    public class Triangulo
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

        public double getlado1()
        {
            return lado1;
        }

        public double getlado2()
        {
            return lado2;
        }

        public double getlado3()
        {
            return lado3;
        }

        public void setLados(double lado1, double lado2, double lado3)
        {
            if(lado1 >= 1.0 && lado2>= 1.0 && lado3>=1.0)
            {
                if(lado1 + lado2> lado3 && lado2+lado3 > lado1 && lado1 + lado3 > lado2)
                {
                    this.lado1 = lado1;
                    this.lado2 = lado2;
                    this.lado3 = lado3;
                }
            }
        }

        public string tipo()
        {
            if (lado1==lado2 && lado2==lado3 && lado1==lado3)
            {
                return "Equilatéro";
            }
            
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
