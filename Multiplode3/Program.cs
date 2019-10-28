using System;

namespace Multiplode3
{
    class Program
    {
        //10. Crie um programa que peça para o usuário entrar com um número 
        //e imprimir uma das mensagens: é multiplo de 3 ou não é multiplo de 3
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("      MULTIPLO DE 3");
            Console.WriteLine("==========================");

            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 3 == 0)
            {
                Console.WriteLine("O número: "+numero+", É MULTIPLO DE 3!");
            }
            else
            {
                Console.WriteLine("O número: "+numero+", NÃO É MULTIPLO DE 3");
            }
        }
    }
}
