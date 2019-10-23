using System;

namespace ValoresTrocados
{
    class Program
    {
        //5. Criar uma aplicação que leia dois valores para as variáveis A e B, efetuar a troca dos vatores de forma que 
        //a variável A passe a ter o valor da variável 8 e que a variável B passe a ter o valor da variável A. Apresentar os valores trocados.

        static void Main(string[] args)
        {
          Console.WriteLine("Informe o valor de A:");        
          int A = int.Parse(Console.ReadLine());
          Console.WriteLine("Informe o valor de B:");
          int B = int.Parse(Console.ReadLine());

          Console.WriteLine("A = "+B);
          Console.WriteLine("B = "+A);
        }
    }
}
