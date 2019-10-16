using System;
using System.Collections.Generic;

namespace Lista___Salário_funcionario
{
    class Program
    {
        //Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salário)
        // de N funcionários. Não deve haver repetição de id
        //Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
        //Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar 
        //uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
        //conforme exemplos.
        //Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser
        //mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por 
        // porcentagem dada;

        static void Main(string[] args)
        {

            List<Funcionarios> lista = new List<Funcionarios>();

            Console.WriteLine("QUANTIDADE DE FUNCIONÁRIOS:");
            int quantFunci = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantFunci; i++)
            {
                Console.WriteLine($"{i}º Funcionário :");
                Console.WriteLine("ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("NOME:");
                string nome = Console.ReadLine();
                Console.WriteLine("SALÁRIO: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionarios(id, nome, salario));
            }

            Console.WriteLine("INFORME O ID PARA O AUMENTO DO SALÁRIO:");
            int IdSalario = int.Parse(Console.ReadLine());

            Funcionarios func = lista.Find(x => x.Id == IdSalario);
            if(func != null)
            {
                Console.WriteLine("INFORME A PORCENTAGEM:");
                double porcen = int.Parse(Console.ReadLine());
                func.Aumento(porcen);
            }
            else
            {
                Console.WriteLine("ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach(Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
