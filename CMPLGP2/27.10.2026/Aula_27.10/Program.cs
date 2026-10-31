using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27._10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int idade = int.Parse("3");

                if (idade < 18)
                {
                    throw new ErroCriticoException(789, "Tem que ser maior de idade");
                }



                Console.WriteLine("Fim do bloco try");

            }
            catch (ErroCriticoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Digite um inteiro válido");
            }
            catch (OverflowException ex) 
            {
                Console.WriteLine("Digite um inteiro menor");
            }
      
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Fecha a conexão com o Banco de Dados");
            }



            Console.WriteLine("Fim da execução");

        }
    }
}
