/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
Console.Write("Digite o numero da tabuada: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0 ; i<=10; i++)
{
    Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
}
 
  }
}