using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioReferenciaAbajurLampada
{

    internal class Lampada
    {
        private bool estadoLampada;

        public Lampada()
        {
            estadoLampada = false;
        }

        public void acende()
        {
            estadoLampada = true;
        }
        public void apaga()
        {
            estadoLampada = false;
        }

        public void mostraEstado()
        {
            if (estadoLampada == true)
            {
                Console.WriteLine("A lâmpada está acesa");

            }
            else
            {
                Console.WriteLine("A lâmpada está apagada");

            }
        }



    }
}
