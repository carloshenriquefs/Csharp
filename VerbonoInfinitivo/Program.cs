using System;

namespace VerboInfinitivo
{
    class Program
    {
        //14. Crie um programa que permita ao usuário entrar com um verbo no infinitivo e imprimir uma das mensagens:
        //Verbo não está no infinitivo.
        //Verbo da 1ª- conjugação.
        //Verbo da 2ª- conjugação.
        //verbo da 3ª- conjugação.
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("    VERBO NO INFINITIVO");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.Write("Informe uma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("====================");
            Console.WriteLine();

            if(palavra.Contains("ar"))
            {
                Console.WriteLine("A palavra: "+palavra+" é um Verbo da 1º conjugação!");
            }
            else if(palavra.Contains("er"))
            {
                Console.WriteLine("A palavra: "+palavra+" é um Verbo da 2º conjugação!");
            }
            else if(palavra.Contains("ir"))
            {
                Console.WriteLine("A palavra: "+palavra+" é um Verbo da 3º conjugação!");
            }
            else
            {
                Console.WriteLine("Verbo não está no infinitivo!");
            }
        }
    }
}