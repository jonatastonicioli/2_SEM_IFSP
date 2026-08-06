/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
  
Console.Write("Digite o número a ser verificado: ");
int num = int.Parse(Console.ReadLine());

if (num%2 == 0 )
{
    Console.WriteLine("O número é par");
    
}else{
    Console.WriteLine("O número é ímpar");
}
      
  }
}