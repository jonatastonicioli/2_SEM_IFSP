/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
  
  Console.Write("Digite o num1: ");
  int num1 = int.Parse(Console.ReadLine());
  
  Console.Write("Digite o num2: ");
  int num2 = int.Parse(Console.ReadLine());
  
  int soma = num1 + num2;
  
  Console.WriteLine("A soma dos dois numeros é {0}", soma);
      
  }
}