using System;

namespace PessoaMaisVelha
{
    class Program
    {
        //Fazer um programa para ler os dados de duas pessoas, depois mostrar
        //o nome da pessoa mais velha
        static void Main(string[] args)
        {
            Pessoa p1,p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p2.Idade > p1.Idade)
            {
                Console.WriteLine("A Segunda pessoa é mais velha!");
            }
            else
            {
                Console.WriteLine("A primeira pessoa é mais velha!");
            }
        }
    }
}
