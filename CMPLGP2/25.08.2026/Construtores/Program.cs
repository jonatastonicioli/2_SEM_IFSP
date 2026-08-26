using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
     class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ana", 7.5, 8.9); // objeto passando 3 parametros
            
            // Aluno a1 = new Aluno("Ana"); objeto que recebe uma string


            //a1.setNota1(10.0);  //como o nota1 esta com o metodo private nao da 
            //para acessá-lo com o operador ponto, assim é criado um metodo void na classe
            //para valida-lo
            //a1.setNota2(5.0);


            //a1.nota1 = 7.5;
            //a1.nota2 = 9.2;


            a1.setNotas(8.0, 7.0); // se fazer o metodo setNotas da pra chamar direto
     

            Console.WriteLine("Aluno: {0}", a1.getNome());
            Console.WriteLine("Nota1: {0}", a1.getNota1());
            Console.WriteLine("Nota2: {0}", a1.getNota2());
            Console.WriteLine("Media: {0}", a1.media());  
            

        }
    }
}
