using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            
            f1.setNome("Jônatas");
            f1.setSalario(1874);
            f1.setHoras(9);
            f1.setValor(20);

            f1.gerarRelatorio();

            Funcionario f2 = new Funcionario("Lucas", 2000, 5, 20);

            f2.gerarRelatorio();
        }


    }
}
