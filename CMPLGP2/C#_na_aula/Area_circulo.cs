/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      const float PI = 3.1415f;
      
      Console.Write("Digite o raio do círculo: ");
      
      float raio = float.Parse(Console.ReadLine());
      
      float area = PI * raio * raio;
      
      Console.Write("A área do círculo é: {0:0.000}", area);
  }
}