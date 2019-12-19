using System;

namespace NumeroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1,20);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite)
                {
                   numeroEncontrado = true;
                   var corAnterior = Console.BackgroundColor;
                   Console.BackgroundColor = ConsoleColor.Blue;
                   Console.WriteLine("Número encontrado em {0} tentativas", tentativas); 
                }else if(palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }else{
                    Console.WriteLine("Maior...Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}",tentativasRestantes);
                }

            }
        }
    }
}
