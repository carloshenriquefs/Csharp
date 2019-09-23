using System;

namespace Datadenascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2019;    
            int idade = 0;

            Console.WriteLine("DATA DE NASCIMENTO:");
            Console.Write("Informe a sua data de nascimento:");
            int ano = int.Parse(Console.ReadLine());

            idade = anoAtual - ano;

            Console.WriteLine("A sua idade é de: "+idade+" anos");

            if(idade > 0 && idade < 2)
            {
                Console.WriteLine("Recém-Nascido!");
            }
            else if(idade > 3 && idade < 11)
            {
                Console.WriteLine("Criança!");
            }
            else if(idade > 12 && idade < 19)
            {
                Console.WriteLine("Adolescente!");
            }
            else if(idade > 20 && idade < 65)
            {
                Console.WriteLine("Adulto!");
            }
            else if(idade > 65 && idade < 65)
            {
                Console.WriteLine("Idoso");
            }


     
        }
    }
}
