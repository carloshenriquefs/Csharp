using System;
using Banda_de_Músicas.Models;
using Banda_de_Músicas.Interfaces;
using System.Collections.Generic;

namespace Banda_de_Músicas
{
    enum FormacaoEnum : int
    {
        TRIO = 3, QUARTETO
    };

    enum InstrumentosEnum : int {BAIXO, BATERIA,CONTRABAIXO,GUITARRA,TECLADO,TAMBORES,VIOLAO};

    enum CategoriaEnum : int {HARMONIA,PERCUSSAO,MELODIA};


    class Program
    {
        static void Main(string[] args)
        {
            // Instrumentos generico = new Instrumentos();
            // Console.WriteLine("Generico:" + generico.TocarMusica());
            

            // Violao violao1 = new Violao();
            // Console.WriteLine("Violão: " + violao1.TocarMusica());
            // violao1.TocarAcordes();

            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "  - 0       ",
                "  - 1       "
            };

            int opcaoFormacaoSelecionada = 0;
            string menubar = "=====================";

            do
            {
                bool formacaoEscolhida = false;

                do
                {
                    Console.Clear();
                    Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Seja bem-vind@ ");
                    Console.WriteLine(" Escolha uma formação: ");
                    Console.ResetColor();
                    Console.WriteLine(menubar);

                    for(int i = 0; i < opcoesFormacao; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if(opcaoFormacaoSelecionada == i)
                        {
                            DestacarOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }

                        var key = Console.ReadKey(true).Key;
                        switch(key)
                        {
                            case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;

                            case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;

                            case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;

                        }
                    }while(!formacaoEscolhida);

                    bool bandaCompleta = false;
                    int vagas = 0;

                    switch(opcaoFormacaoSelecionada)
                    {
                        case 0:
                        vagas = 2;
                        do
                        {
                            ExibirMenuDeInstrumentos();
                            Console.Write($"Digite o código do instrumento de  harmonia:");
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];
                            vagas--;
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if(interfaceEncontrada != null)
                            {
                                ColocarnaBanda((IHarmonia)instrumento);
                            }
                            else
                            {
                                continue;
                            }

                            Console.Write($"Digite o código do instrumento de percussao:");
                            codigos = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];
                            vagas--;
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IPercussão");

                            if(interfaceEncontrada != null)
                            {
                                ColocarnaBanda((IPercussao)instrumento);
                            }
                            else
                            {
                                continue;
                            }

                            if(vagas == 0)
                            {
                                bandaCompleta = true;
                            }

                        }while(!bandaCompleta);
                        Console.WriteLine("Banda Completa");
                        Console.ReadLine();
                        break;
                        case 1:
                        vagas = 3;
                        do{

                        
                            ExibirMenuDeInstrumentos();
                            Console.Write($"Digite o código do instrumento de  harmonia:");
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];
                            vagas--;
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if(interfaceEncontrada != null)
                            {
                                ColocarnaBanda((IHarmonia)instrumento);
                            }
                            else
                            {
                                continue;
                            }

                            Console.Write($"Digite o código do instrumento de percussao:");
                            codigos = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];
                            vagas--;
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IPercussão");

                            if(interfaceEncontrada != null)
                            {
                                ColocarnaBanda((IPercussao)instrumento);
                            }
                            else
                            {
                                continue;
                            }
                            
                            Console.WriteLine($"Digite o código do instrumento de Melodia: ");
                            instrumento = Deposito.Instrumentos[codigo];
                            vagas--;

                              if(interfaceEncontrada != null)
                            {
                                ColocarnaBanda((IMelodia)instrumento);
                            }
                            else
                            {
                                continue;
                            }

                            if(vagas == 0)
                            {
                                bandaCompleta = true;
                            }

                        }while(!bandaCompleta);
                        Console.WriteLine("Banda Completa");
                        Console.ReadLine();
                        break;
                }while(!querSair);
                    
                }
            }

        }
    }
}
