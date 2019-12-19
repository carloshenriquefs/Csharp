using System;

namespace NumeroAleatorioBREAK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numero = random.Next(1,51);

            Console.WriteLine("O número escolhido foi: {0}",numero);
            Console.WriteLine();

            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("O número escolhido é:{0}",i);
                if(numero == i)
                {
                    Console.WriteLine("Sim, esse foi o número escolhido!!!");
                    break;
                }
                else{
                    Console.WriteLine("Não, esse não foi o número escolhido!!!");
                }
            }
        }
    }
}
