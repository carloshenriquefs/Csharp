using System;
using MateODragao.Models;
// using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNdesis = true;
            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("   MATE O DRAGÃO");
                Console.WriteLine("====================");

                System.Console.WriteLine("1 - Iniciar jogo:");
                System.Console.WriteLine("0 - Sair do jogo:");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        //CTRL + . + PRIMEIRA OPCAO
                        guerreiro.Nome = "HACKEN";
                        guerreiro.Sobrenome = "ULTIMATE";
                        guerreiro.CidadeNatal = "Acre";
                        guerreiro.DataN = DateTime.Parse("3 mil antes de Cristo");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Escudo";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 2;
                        guerreiro.Inteligencia = 4;
                        guerreiro.Vida = 20;

                        Dragon dragao = new Dragon();
                        dragao.Nome = "GRETCHEN";
                        dragao.Forca = 6;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 1;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro Dialogo */
                        //ALT + SHIFT + SETA PRA BAIXO
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:{dragao.Nome},Pode Vim, FDP! O CHURRASCO COMEÇA AQUI!!!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}:{dragao.Nome},Eu vou trocar o seu Sexo!\n");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        /* FIM - Primeiro Dialogo */

                        /* INICIO - Segundo Dialogo */
                        Console.Clear();
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}{guerreiro.Sobrenome}! ");

                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim do {guerreiro.CidadeNatal} a procura da Conga-lá Conga ");

                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}:Vai queimar humano!!");

                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        /* FIM - Segundo Dialogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNcorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /*INICIO - da treta */
                        if (jogadorAtacaPrimeiro)
                        {
                            Console.Clear();

                            System.Console.WriteLine("Turno do Jogador");
                            System.Console.WriteLine("Escolha sua ação:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumero = new Random();
                                    int numeroaleatoriojoga = geradorNumero.Next(0, 5);
                                    int numeroaleatoriodragao = geradorNumero.Next(0, 5);

                                    int guerreiroDestrezaT = guerreiro.Destreza + numeroaleatoriojoga;
                                    int dragaoDestrezaT = guerreiro.Destreza + numeroaleatoriodragao;

                                    if (guerreiroDestrezaT > dragaoDestrezaT)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:Toma essa MOCORONGO");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine("------------------");
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}:ERROU!!");
                                    }

                                    break;
                                case "2":
                                    jogadorNcorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:CORRE NEGADA!!!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}:CORRE NEGADA!!!");

                                    break;
                            }

                            /*FIM - da treta */

                            Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNcorreu)
                            {
                                Console.Clear();
                                System.Console.WriteLine("=== TURNO DO DRAGÃO ===");
                                Random geradorNumero = new Random();
                                int numeroaleatoriojoga = geradorNumero.Next(0, 5);
                                int numeroaleatoriodragao = geradorNumero.Next(0, 5);

                                int guerreiroDestrezaT = guerreiro.Destreza + numeroaleatoriojoga;
                                int dragaoDestrezaT = guerreiro.Destreza + numeroaleatoriodragao;

                                if (dragaoDestrezaT > guerreiroDestrezaT)
                                {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}:Queima a rosca!!!");
                                    guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine("------------------");
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                else
                                {
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:ERROU!!");
                                }
                                System.Console.WriteLine();
                                System.Console.WriteLine("Aperte ENTER para prosseguir");
                                Console.ReadLine();
                                /* INICIO - Turno Jogador */
                                Console.Clear();
                                System.Console.WriteLine("Turno do Jogador");
                                System.Console.WriteLine("Escolha sua ação:");
                                System.Console.WriteLine("1 - Atacar");
                                System.Console.WriteLine("2 - Fugir");

                                opcaoBatalhaJogador = Console.ReadLine();

                                switch (opcaoBatalhaJogador)
                                {
                                    case "1":
                                        geradorNumero = new Random();
                                        numeroaleatoriojoga = geradorNumero.Next(0, 5);
                                        numeroaleatoriodragao = geradorNumero.Next(0, 5);

                                        guerreiroDestrezaT = guerreiro.Destreza + numeroaleatoriojoga;
                                        dragaoDestrezaT = guerreiro.Destreza + numeroaleatoriodragao;

                                        if (guerreiroDestrezaT > dragaoDestrezaT)
                                        {
                                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:Toma essa MOCORONGO");
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine("------------------");
                                            System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}:ERROU!!");
                                        }

                                        if (guerreiro.Vida <= 0)
                                        {
                                            System.Console.WriteLine("JOGADOR MORREU!!!");
                                        }
                                        if (dragao.Vida <= 0)
                                        {
                                            System.Console.WriteLine("DRAGÃO MORREU!");
                                        }
                                        System.Console.WriteLine();
                                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                                        Console.ReadLine();
                                        break;

                                    case "2":
                                        jogadorNcorreu = false;
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:CORRE NEGADA!!!");
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}:CORRE NEGADA!!!");
                                        break;
                                }

                                /*FIM - da treta */
                                Console.WriteLine();
                                Console.WriteLine("Aperte ENTER para prosseguir");
                                Console.ReadLine();
                                /* FIM - Turno Jogador */
                            }
                        }

                        break;

                    case "0":
                        jogadorNdesis = false;
                        break;

                    default:
                        System.Console.WriteLine("Comando desconhecido");
                        break;
                }
            } while (jogadorNdesis);

            //ALT+SHIFT+F - Formatação
        }
    }
}
