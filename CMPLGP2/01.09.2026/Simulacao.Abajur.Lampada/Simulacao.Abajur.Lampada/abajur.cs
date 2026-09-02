using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao.Abajur.Lampada
{
     class Abajur
    {
        private Lampada lampada; //Lampada (Lampada é uma referencia(classe), é o tipo de variável) (lampada nome variavel)
        // referencia
        
        public Abajur()
        {
            lampada = null;
        }

        public void encaixaLampada (Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void liga()
        {
            if (lampada != null)
            {
                lampada.acende();
            }
        }

        public void desliga()
        {
            if (lampada != null)
            {
                lampada.apaga();
            }
        }

        public void mostraEstado()
        {
            if (lampada != null)
            {
                Console.Write("Abajur com: ");
                lampada.mostraEstado();
            }
            else
            {
                Console.WriteLine("Abajur sem lâmpada");
            }
        }
    }
}
