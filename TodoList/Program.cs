using System;
using System.IO;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static int Main(string[] args)

        {
            //REGION Carrega a lista de afazeres do disco
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo copy.csv";
            string filePath = ".\\" + fileName;

            //Caracter especial = .\\
            //Leia em texto e quebre em linhas = ReadAllLines

            todoList = initList(@filePath);

            if (todoList == null)
            {//Termina a aplicação porque a lista de afazeres nçao carrega
                return -1;
            }//A lista carregou. Continua a execução
            else
            {
                int opcao = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Todo List");
                    Console.WriteLine();
                    ListaItens(todoList);
                    Console.WriteLine();
                    Console.WriteLine("Digite uma opção:");
                    Console.WriteLine("1 - Adicionar Item");
                    Console.WriteLine("2 - Remover Item");
                    Console.WriteLine("3 - Terminar");
                    Console.Write("Opção:");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            AddItem(todoList);
                            break;
                        case 2:
                            RemoveItem(todoList);
                            break;
                        case 3:
                            Console.WriteLine("Tchau!!!!");
                            SaveList(todoList, @filePath);
                            break;
                        default:
                            Console.WriteLine("Opção Invalida");
                            Console.ReadLine();
                            break;
                    }

                } while (opcao != 3);

                return 0;
            }
        }

        static List<TodoItem> initList(string filePath)
        {

            List<TodoItem> todoList = new List<TodoItem>();
            try
            {//monitorado pelo framework
                string[] todoFile = File.ReadAllLines(@filePath);

                foreach (string line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"", "");
                    string nota = itens[1].Replace("\"", "");
                    TodoItem todoItem = new TodoItem(titulo, nota);
                    todoList.Add(todoItem);
                }
                //Remove o CABEÇALHO DO ARQUIVO
                todoList.RemoveAt(0);
                return todoList;
            }

            //line.Split quebra a virgula e separa, editando as frases titulo e nota
            //IOException = classe,Tipo de dados da variavel [e]
            catch (IOException e)//vigia o problema = catch | todos os erros de IO = Exception
            {
                Console.WriteLine("Erro de Acesso");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        static void ListaItens(List<TodoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            Console.WriteLine("Todo List");
            Console.WriteLine();
            Console.WriteLine($"ID{"",2} Titulo: {"",12} Notas");
            foreach (TodoItem item in todoList)
            {
                Console.WriteLine($"{count,2}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }

        static void AddItem(List<TodoItem> todoList)
        {
            Console.Clear();
            Console.WriteLine("Novo Item");
            Console.WriteLine();
            Console.WriteLine("Titulo:");
            string titulo = Console.ReadLine();
            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);
            todoList.Add(item);
        }

        static void RemoveItem(List<TodoItem> todoList)
        {
            int index = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Remove Item");
                Console.WriteLine();
                ListaItens(todoList);
                Console.WriteLine();
                Console.WriteLine("Digite o ID ou x para terminar");
                Console.WriteLine("ID: ");
                string id = Console.ReadLine();

                if (id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = int.Parse(id);
                }

                if (index < 0 || index > todoList.Count - 1)
                {
                    Console.WriteLine("ID inválido");
                    Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                }
                else
                {
                    todoList.RemoveAt(index);
                }
            } while (true);
        }


        static void SaveList(List<TodoItem> lista, string path)
        {
            List<string> linha = new List<string>();
            linha.Add("title,note");
            foreach (TodoItem item in lista)
            {
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Nota + "\"";
                linha.Add(titulo + "," + nota);
            }
            string tryAgain = "n";
            do
            {
                try
                {
                    File.WriteAllLines(@path, linha);
                }
                catch (IOException e)
                {
                    Console.WriteLine("ERRO DE LEITURA DO ARQUIVO");
                    Console.WriteLine(e.Message);
                    do
                    {
                        Console.WriteLine("Deseja tentar novamente (S/N)?");
                        tryAgain = Console.ReadLine().ToLower();
                        if ((tryAgain != "n") || (tryAgain != "s"))
                        {
                            Console.WriteLine("Opção Invalida!!!");
                        }

                    } while ((tryAgain == "s") || (tryAgain == "n"));
                }
            } while (tryAgain != "n");

        }
    }
}
