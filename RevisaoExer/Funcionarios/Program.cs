using System;
using System.Collections.Generic;

namespace Funcionarios {
    class Program {
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

        static void Main (string[] args) {
            Console.WriteLine ("[ FUNCIONÁRIOS ]");
            Console.WriteLine ();
            List<Funcionarios> lista = new List<Funcionarios> ();

            Console.Write ("Quantos funcionários: ");
            int funcionarios = int.Parse (Console.ReadLine ());

            for (int i = 0; i < funcionarios; i++) {
                Console.WriteLine ("Funcionário #" + i + 1);
                Console.Write ("ID: ");
                int id = int.Parse (Console.ReadLine ());
                Console.Write ("Nome: ");
                string nome = Console.ReadLine ();
                Console.Write ("Salário: ");
                double salario = double.Parse (Console.ReadLine ());
                lista.Add (new Funcionarios (id, nome, salario));
            }

            Console.Write ("Informe o ID do funcionário: ");
            int procurarId = int.Parse (Console.ReadLine ());

            Funcionarios funcionario = lista.Find (x => x.ID == procurarId);

            if (funcionario != null) {
                Console.Write ("Informar o aumento no percentual: ");
                int porcentagem = int.Parse (Console.ReadLine ());
                funcionario.SalarioAumento(porcentagem);
            }
            else
            {
                Console.WriteLine("ID não encontrado!");
            }
            
            Console.WriteLine();
            Console.WriteLine("[ Funcionários ]");
            foreach(Funcionarios nomes in lista)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}