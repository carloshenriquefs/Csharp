using System;
using System.Collections.Generic;

namespace NumerosCrescentes {
    class Program {
        static void Main (string[] args) {
            
            Console.WriteLine("ORDEM CRESCENTE");
          
            Console.WriteLine();
            Console.WriteLine("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());

           List<int> numeros = new List<int>();
           numeros.Add(num1);
           numeros.Add(num2);
           numeros.Add(num3);

           numeros.Sort();

            Console.WriteLine("ORDEM CRESCENTE");
           foreach(int item in numeros)
           {
            Console.Write("-"+item);
           }
        }
    }
}