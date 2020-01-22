using System;

namespace ListagemNumArrays
{
    class Program
    {
        //Criar um programa que dado um vetor de inteiros com N posições
        //determinadas pelo usuário, permita que usuário digite esses N
        //numeros através de um prompt na console, listando os valores digitados.

        static void Main(string[] args)
        {

            Console.Write("Quantidade de valores: ");
            int qtdNumero = int.Parse(Console.ReadLine());

            int [] numero = new int[qtdNumero];

            for(int i = 0; i < qtdNumero; i++)
            {
                Console.Write("Informe o número: ");
                int num = int.Parse(Console.ReadLine());
                numero[i] = num;
                Console.WriteLine("Número digitado foi: {0} na posição: {1}",numero[i] , i);
            }
        }
    }
}
