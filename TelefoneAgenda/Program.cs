using System;
using System.Collections.Generic;
using TelefoneAgenda;

namespace TelefoneAgenda
{
    class Program
    {
        //28. Crie uma aplicação chamada AgendaTelefonica que implemente a seguinte classe:
        //A classe teve ter um construtor que permita a passagem do nome, telefone e aniversario, os métodos de acesso para todos os atributos.
        //A aplicação deve criar uma instância da classe registo e permitir que o usuário entre com os dados do registro.
        //29. Modifique a aplicação AgendaTelefonica para que ela permita uma quantidade arbritária de registros. Além disso a aplicação deverá ter a seguintes funcionalidades:
        //Casdastro, Atualização e Remoção de Registos.
        //Busca por nome.
        //Busca por aniversário.
        //Listagem dos registros.
        static void Main(string[] args)
        {
            // var Cadastro = new Dictionary<string, string>();
            List<Registro> Agenda = new List<Registro>();

            Console.WriteLine("AGENDAR CADASTRO? [S/N]");
            string SimNao = (Console.ReadLine().ToUpper());
            do
            {
                Console.WriteLine();
                Console.WriteLine("=============================");
                Console.WriteLine("      AGENDA TELEFÔNICA");
                Console.WriteLine("=============================");
                Console.WriteLine();
                Console.WriteLine("           [MENU]");
                Console.WriteLine();
                Console.WriteLine("[1] - CADASTRO: ");
                Console.WriteLine("[2] - ATUALIZAÇÃO: ");
                Console.WriteLine("[3] - REMOÇÃO DE REGISTROS: ");
                Console.WriteLine("[4] - BUSCAR NOME: ");
                Console.WriteLine("[5] - BUSCA POR ANIVERSÁRIO: ");
                Console.WriteLine("[6] - LISTAGEM DOS REGISTROS: ");
                Console.WriteLine();
                Console.Write("ESCOLHA UMA OPÇÃO DO MENU: ");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("[1] - CADASTRO: ");
                    Agenda.Add(Cadastro(Agenda));
                    // Console.WriteLine(Agenda[0].Nome);
                    // Console.WriteLine(Agenda[0].Telefone);
                    // Registro cadastro = new Registro();
                    // cadastro.Nome = NomeCadastro;

                }
                else if (menu == 2)
                {
                    Console.WriteLine("[2] - ATUALIZAÇÃO: ");
                    Agenda.Add(Atualizar(Agenda));
                }
                else if (menu == 3)
                {
                    Console.WriteLine("[3] - REMOÇÃO DE REGISTROS: ");
                    Agenda.Add(RemocaoRegistros(Agenda));
                }
                else if (menu == 4)
                {
                    Console.WriteLine("[4] - BUSCAR NOME: ");
                }
                else if (menu == 5)
                {
                    Console.WriteLine("[5] - BUSCA POR ANIVERSÁRIO: ");
                }
                else if (menu == 6)
                {
                    Console.WriteLine("[6] - LISTAGEM DOS REGISTROS: ");
                }
                Console.WriteLine();
                Console.WriteLine("CONTINUAR? [S/N]");
                SimNao = (Console.ReadLine().ToUpper());
            } while (SimNao == "S");
        }

        public static Registro Cadastro(List<Registro> CadastroAgenda)
        {

            Console.WriteLine();
            Console.WriteLine("        [INFORME]");
            Console.WriteLine();

            Console.Write("POSIÇÃO: ");
            string posicao = Console.ReadLine();

            Registro Nomes = new Registro();
            // Nomes.QuantidadePessoas();
            Console.Write("NOME: ");
            string NomeCadastro = Console.ReadLine();
            Nomes.Nome = NomeCadastro;

            Registro TelefoneCadastro = new Registro();
            Console.Write("TELEFONE: ");
            string numeroTelefone = Console.ReadLine();
            TelefoneCadastro.Telefone = numeroTelefone;

            Registro AniversarioCadastro = new Registro();
            Console.Write("ANIVERSÁRIO: ");
            string dataAniversario = Console.ReadLine();
            AniversarioCadastro.Aniversario = dataAniversario;

            Console.WriteLine();

            // Registro registro = new Registro("Carlos", "2541-2596", "12/03/1998");
            Registro registro = new Registro(Nomes.Nome, TelefoneCadastro.Telefone, AniversarioCadastro.Aniversario);
            Console.WriteLine("========================================================================");
            Console.WriteLine($"| {posicao} | NOME: {Nomes.Nome} | TELEFONE: {TelefoneCadastro.Telefone} | ANIVERSÁRIO: {AniversarioCadastro.Aniversario} |");
            Console.WriteLine("========================================================================");
            return registro;

        }

        public static Registro Atualizar(List<Registro> AtualizarAgenda)
        {
            Console.WriteLine();
            Console.WriteLine("   [INFORME]");
            Console.WriteLine();
            Console.WriteLine("ATUALIZE OS DADOS: ");
            Console.WriteLine();
            Console.WriteLine("MENU ALTERAÇÃO: ");
            Console.WriteLine("[1] - NOME: ");
            Console.WriteLine("[2] - TELEFONE: ");
            Console.WriteLine("[3] - ANIVERSÁRIO: ");
            Console.WriteLine("[4] - TODOS: ");
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.Write("Escolha a sua opção: ");
            int opção = int.Parse(Console.ReadLine());
            Console.WriteLine("======================");
            Console.WriteLine();
            if (opção == 1)
            {
                Console.WriteLine("[1] - NOME: ");
                Console.WriteLine("NOME: ");
                string atualizarNome = Console.ReadLine();
                Registro NomeA = new Registro();
                NomeA.Nome = atualizarNome;

            }
            else if (opção == 2)
            {
                Console.WriteLine("[2] - TELEFONE: ");
                Console.Write("TELEFONE: ");
                string atualizarTelefone = Console.ReadLine();
                Registro TelefoneA = new Registro();
                TelefoneA.Telefone = atualizarTelefone;

            }
            else if (opção == 3)
            {
                Console.WriteLine("[3] - ANIVERSÁRIO: ");
                Console.Write("ANIVERSÁRIO: ");
                string atualizarAniversario = Console.ReadLine();
                Registro AniversarioA = new Registro();
                AniversarioA.Aniversario = atualizarAniversario;

            }
            else if (opção == 4)
            {
                Console.WriteLine("[4] - TODOS: ");
                Console.Write("NOME: ");
                string AtualizarNomeT = Console.ReadLine();
                Registro NomeTodos = new Registro();
                NomeTodos.Nome = AtualizarNomeT;

                Console.Write("TELEFONE: ");
                string AtualizarTelefoneT = Console.ReadLine();
                Registro TelefoneTodos = new Registro();
                TelefoneTodos.Telefone = AtualizarTelefoneT;

                Console.WriteLine("ANIVERSÁRIO: ");
                string AtualizarAniversarioT = Console.ReadLine();
                Registro AniversarioTodos = new Registro();
                AniversarioTodos.Aniversario = AtualizarAniversarioT;
                Registro atualizar1 = new Registro(NomeTodos.Nome, TelefoneTodos.Telefone, AniversarioTodos.Aniversario);

            }
            Registro atualizar = new Registro("Rogerio", "2541-9874", "14/06/1990");
            return atualizar;
        }

        public static Registro RemocaoRegistros(List<Registro> RemoverAgenda)
        {
            Console.Write("REMOVER NOME");
            string NomeRemover = Console.ReadLine();
            foreach (var item in RemoverAgenda)
            {
                if (item.Nome == NomeRemover)
                {
                    RemoverAgenda.Remove(item);
                    Console.WriteLine(item);
                }

            }

            Registro remover = new Registro();
            return remover;
        }

        // static Registro BuscaNome(List<Registro> BuscarAgenda)
        // {

        // } 

        // static Registro BuscaAniversario(List<Registro> BuscaAgenda)
        // {

        // }

        // static Registro ListaRegistros(List<Registro> ListaAgenda)
        // {

        // }

    }
}