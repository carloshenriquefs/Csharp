using System;

namespace SequenciaIJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j =7;

            for(i = 1, j = 7; j<=7;i=i+1,j=j-1)
            {
                Console.WriteLine($"I = {i} J = {j}");
            }
        }
    }
}
