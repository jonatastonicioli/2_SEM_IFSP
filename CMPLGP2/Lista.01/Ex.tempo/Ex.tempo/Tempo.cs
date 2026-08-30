using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Tempo
    {
        private int hora;
        private int minuto;
        private int segundo; // n pode ser acessado com o operador ponto

        public Tempo() //construtor sem parametros
        {
            hora = 23;
            minuto = 59;
            segundo = 59;
        }

        public Tempo(int hora, int minuto, int segundo) // construtor com parametros

        {
            this.hora = hora; //this.hora é o campo, hora é o parâmetro
            this.minuto = minuto;
            this.segundo = segundo;
        }

        public void setHora(int hora)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
            }
            else
            {
                Console.WriteLine("O valor da hora deve ser entre 0 e 23");
            }
        }

        public void setMinuto(int minuto)
        {
            if (minuto >= 0 && minuto <= 59)
            {
                this.minuto = minuto;
            }
            else
            {
                Console.WriteLine("O valor do minuto deve ser entre 0 e 59");
            }
        }

        public void setSegundo(int segundo)
        {
            if (segundo >= 0 && segundo <= 59)
            {
                this.segundo = segundo;
            }
            else
            {
                Console.WriteLine("O valor do segundo dever ser entre 0 e 59");
            }
        }

        public int getHora()
        {
            return hora;
        }
        public int getMinuto()
        {
            return minuto;
        }
        public int getSegundo()
        {
            return segundo;
        }
        public int totalSegundos()
        {
            int segundos;
            return segundos = (hora * 3600 + minuto * 60 + segundo);
        }
        public void imprimeTempoSimples()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hora, minuto, segundo); //:D2 para sempre formatar com dois dígitos mesmo se for <0
        }
        public void imprimeTempoExtenso()
        {
            Console.WriteLine("{0} hora(s), {1} minuto(s) e {2} segundo(s)", hora, minuto, segundo);
        }
           
    }
}
        
        
       



