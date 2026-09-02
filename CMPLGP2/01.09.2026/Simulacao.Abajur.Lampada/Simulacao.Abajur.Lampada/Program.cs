using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao.Abajur.Lampada
{
     class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp = new Lampada();
            
            Abajur abajur = new Abajur();

            //abajur.encaixaLampada(lamp); // conexão entre as classes lampada e abajur
            
            abajur.mostraEstado();
            
            abajur.liga();

            abajur.mostraEstado();

            lamp.mostraEstado();



           

        }
    }
}
