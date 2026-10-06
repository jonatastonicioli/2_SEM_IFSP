using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_01__Cofrinho_
{
    internal class Cofrinho
    {
        private List<Moeda> lista = new List<Moeda>();

        public void inserirMoeda(Moeda moeda)
        {
            lista.Add(moeda);
        }

        public int quantidadeMoedas ()
        {
            return lista.Count();
        }

        public int MoedasUmReal()
        {
            int qtd = 0;

            foreach (Moeda i in lista)
                {
                if(i.getValor() == 1.0)
                {
                    qtd++;
                }
                
            }
            return qtd;
        }



    }
}
