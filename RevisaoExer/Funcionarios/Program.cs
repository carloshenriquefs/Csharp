using System;
using System.Collections.Generic;

namespace Funcionarios
{
    class Program
    {
        //Fazer um programa para ler um número inteiro N e depois os dados
        //(id, nome e salario) de N funcionarios. Não deve haver repetição
        //de id.
        //Em seguida, efetuar o aumento de X por cento no salário de um 
        //determinado funcionário. Para isso, o programa deve ler um id e o
        // valor X. Se o id informado não existir, mostrar uma mensagem e 
        //abortar a operação. Ao final, mostrar a listagem atualizada dos 
        //funcionarios.
        //Lembre-se de aplicar a tecnica de encapsulamento para permitir 
        // que o salario possa ser mudado livremente. Um salario só pode
        //ser aumentado com base em uma operação de aumento por porcentagem dada

        static void Main(string[] args)
        {
            Console.WriteLine("[ FUNCIONÁRIOS ]");
            Console.WriteLine();
            List<string> lista = new List<string>();

            Console.Write("Quantos funcionários: ");
            int funcionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine("Funcionário #"+i+1);
            }
        }
    }
}
