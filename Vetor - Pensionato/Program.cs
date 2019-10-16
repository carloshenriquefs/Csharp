using System;

namespace Vetor___Pensionato
{
    class Program
    {
        //A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses
        //quartos identifcados pelos números 0 a 9.
        //Fazer um programa que inicie com os dez quartos vazios, e depois leia uma quantidade N
        // representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em
        //seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome
        // e email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja 
        //escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações
        // do pensionado, por odem de quarto, conforme exemplo.

        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("QUANTIDADE DE QUARTOS:");
            int quartos = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < quartos; i++)
            {
                
                Console.Write("NOME:");
                string nome = Console.ReadLine();
                Console.Write("EMAIL:");
                string email = Console.ReadLine();
                Console.WriteLine("QUARTO:");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------");
                vetor[quarto] = new Estudante(nome,email);
            }

            Console.WriteLine();
            Console.WriteLine("QUARTOS OCUPADOS");
            for(int i = 0; i < 10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(i +": "+ vetor[i]);
                }
            }
            
        }
    }
}
