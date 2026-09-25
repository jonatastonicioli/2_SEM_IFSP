using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioReferenciaAbajurLampada
{
    internal class Abajur
    {
        private Lampada lampada; // variavel de referencia


        public Abajur()
        {
            lampada = null;
        }

    public void encaixaLampada(Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void liga()
        {

            if (lampada == null)
            {
                Console.WriteLine("Não há nenhuma lâmpada no abajur");
            }
            else
            {

                lampada.acende(); // ligando a lampada a partir do abajur
            }
        }

        public void desliga()
        {

            if (lampada == null)
            {
                Console.WriteLine("Não há nenhuma lâmpada no abajur");
            }
            else
            {

                lampada.apaga(); 
            }
        }
        public void mostraEstado()
        {

            if (lampada == null)
            {
                Console.WriteLine("Não há nenhuma lâmpada no abajur");
            }
            else
            {

                lampada.mostraEstado(); 
            }
        }




    }
}
