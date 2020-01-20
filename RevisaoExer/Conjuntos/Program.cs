using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            Console.WriteLine("Conjunto A:");
            foreach(int num in A){
                Console.WriteLine(num);
            }

            Console.WriteLine("Conjunto B:");
            foreach(int num1 in B){
                Console.WriteLine(num1);
            }

            Console.WriteLine("A diferença de A e B:");
            A.ExceptWith(B);
            foreach(int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("========================");
            A.IntersectWith(B);

            foreach(int numAB in A)
            {
                Console.WriteLine(numAB);
            }
            Console.WriteLine("========================");
            
            Console.WriteLine();
            Console.Write("Digite um número: ");
            int Num = int.Parse(Console.ReadLine());

            if (A.Contains(Num))
            {
                Console.WriteLine("O conjunto 'A' contém o número: "+Num);
            }
            else
            {
                Console.WriteLine("O conjunto 'A' não contém o número: "+Num);
            }

            Console.WriteLine("Conjunto B:");
            B.Remove(4);
            foreach(int x in B){
                Console.WriteLine(x);
            }
        }
    }
}
