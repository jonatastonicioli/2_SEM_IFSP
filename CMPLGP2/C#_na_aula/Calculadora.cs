/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
int resultado = 0;
  
Console.Write("Digite o num1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o num2: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Digite a operação: ");
char selecao = char.Parse(Console.ReadLine());

 switch(selecao)
 {
  case '+':
  resultado = num1 + num2;
  break;
  
  case '-':
  resultado = num1 - num2;
  break;
  
  case '*':
  resultado = num1*num2;
  break;
  
  case '/':
  resultado = num1/num2;
  break;
 }
 
 Console.Write("O resultado da operação é {0}", resultado);
 
  }
}