using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data();
            d1.setData(1, 12, 2007);
            d1.imprimeDataSimples();
            d1.imprimeDataExtenso();

            Data d2 = new Data();

            d2.setData(22, 09, 1974);
            d2.imprimeDataSimples();
            d2.imprimeDataExtenso();


        }
    }
}
