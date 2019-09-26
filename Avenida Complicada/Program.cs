using System;

namespace Avenida_Complicada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("AVENIDA COMPLICADA");
            Console.WriteLine("==================");

            Console.WriteLine("[1] - COR");
            Console.WriteLine("[2] - NACIONALIDADE");
            Console.WriteLine("[3] - BEBIDA");
            Console.WriteLine("[4] - ANIMAL");
            Console.WriteLine("\n[5] - CARRO");

            Console.WriteLine("Informe os dados:");
            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1){
                Console.WriteLine("[1] - VERDE");
                Console.WriteLine("[2] - CINZA");
                Console.WriteLine("[3] - VERMELHA");
                Console.WriteLine("[4] - AZUL");
                Console.WriteLine("[5] - ROSA");

                Console.WriteLine("Insira a cor:");
                int cor = int.Parse(Console.ReadLine());
                Console.WriteLine("A cor sugerida foi: "+ cor);
            }
            else if(opcao == 2)
            {
                Console.WriteLine("[1] - MEXICANO");
                Console.WriteLine("[2] - BRASILEIRO");
                Console.WriteLine("[3] - ARGENTINO");
                Console.WriteLine("[4] - PERUANO");
                Console.WriteLine("[5] - CHILENO");

                Console.WriteLine("Insira a nacionalidade:");
                int naciona = int.Parse(Console.ReadLine());
                Console.WriteLine("A nacionalidade é:"+ naciona);
            }
        }
    }
}
