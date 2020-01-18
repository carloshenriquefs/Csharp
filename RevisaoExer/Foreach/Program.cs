using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomesVetor = new string [] {"Maria", "João", "Ronaldo"};

            // for(int i = 0; i < nomesVetor.Length; i++)
            // {
            //     Console.WriteLine(nomesVetor[i]);
            // }


            foreach(string nome in nomesVetor)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
