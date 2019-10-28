using System;

namespace ListandoValores
{
    class Program
    {
        //19. Criar um programa que dado um vetor de inteiros com N posições, 
        //determinadas pelo usuário, permita que usuário digite esses N números 
        //através de um prompt na console, listando os valores digitados.

        static void Main(string[] args)
        {
            Console.WriteLine("LISTAGEM DE VALORES");
            Console.WriteLine();
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            int[] numeros = new int[num];

            Console.WriteLine("Digite "+num+" números: ");
            for(int i = 0; i < num; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                numeros[i] = numero;
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Valores:");
            foreach(int valores in numeros)
            {
                Console.Write(valores+ "-");
            }

            
          

        }
    }
}
