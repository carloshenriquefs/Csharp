using System;

namespace DiferencaForDiferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("DIFERENÇA ");
            Console.WriteLine();

            for(int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Informe o "+i+"º número: ");
                int Numero = int.Parse(Console.ReadLine());
            
            double Diferenca = (Numero * Numero - Numero*Numero);
            Console.WriteLine(Diferenca);
            }


        }
    }
}
