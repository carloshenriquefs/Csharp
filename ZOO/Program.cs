using System;
using System.Collections.Generic;
using System.Linq;
using ZOO.Interfaces;

namespace ZOO {
    class Program {
        static void Main (string[] args) {

            List<string> lista = new List<string> ();
            List<int> lista1 = new List<int>();
            Console.WriteLine ();

            Dictionary<int, string> Animais = new Dictionary<int, string> ();

            char SimNao;
            int opcao = 0;
            char ListaAtual;
            do{

                Console.WriteLine ();
                Console.WriteLine ("======================");
                Console.WriteLine ("      ZOOLOGICO");
                Console.WriteLine ("======================");
                Console.WriteLine ();

                Animais.Add (1, "[1] - TUBARÃO MARTELO");
                Animais.Add (2, "[2] - TUCANO");
                Animais.Add (3, "[3] - ARARA ");
                Animais.Add (4, "[4] - LEÃO");
                Animais.Add (5, "[5] - ORANGOTANGO");
                Animais.Add (6, "[6] - CHIMPANZÉ");
                Animais.Add (7, "[7] - PINGUIM");
                Animais.Add (8, "[8] - TARTARUGA");
                Animais.Add (9, "[9] - GOLFINHO");

                foreach (var cadastro in Animais.Keys) {
                    Console.WriteLine (Animais[cadastro]);
                }

                Console.WriteLine ();
                Console.Write ("INFORME UMA OPÇÃO: ");
                opcao = int.Parse (Console.ReadLine ());
                Console.WriteLine ();
                lista1.Add (opcao);
                Console.WriteLine("=================================");
                if (opcao == 1) {
                    Animais.TryGetValue (opcao, out string Animais1);
                    Console.WriteLine ($"Animal: {Animais1}");
                    TubaraoM Tubarao = new TubaraoM ();
                    Tubarao.TubaraoAnimal ();
                } else if (opcao == 2) {
                    Animais.TryGetValue (opcao, out string Animais2);
                    Console.WriteLine ($"Animal: {Animais2}");
                    Tucano tucano = new Tucano ();
                    tucano.TucanoAnimal ();
                } else if (opcao == 3) {
                    Animais.TryGetValue (opcao, out string Animais3);
                    Console.WriteLine ($"Animal: {Animais3}");
                    Arara arara = new Arara ();
                    arara.AraraAnimal ();
                } else if (opcao == 4) {
                    Animais.TryGetValue (opcao, out string Animais4);
                    Console.WriteLine ($"Animal: {Animais4}");
                    Leao leao = new Leao ();
                    leao.LeaoAnimal ();
                } else if (opcao == 5) {
                    Animais.TryGetValue (opcao, out string Animais5);
                    Console.WriteLine ($"Animal: {Animais5}");
                    Orangotango orangotango = new Orangotango ();
                    orangotango.OrangotangoAnimal ();
                } else if (opcao == 6) {
                    Animais.TryGetValue (opcao, out string Animais6);
                    Console.WriteLine ($"Animal: {Animais6}");
                    Chimpanze chimpanze = new Chimpanze ();
                    chimpanze.ChimpanzeAnimal ();
                } else if (opcao == 7) {
                    Animais.TryGetValue (opcao, out string Animais7);
                    Console.WriteLine ($"Animal: {Animais7}");
                    Pinguim pinguim = new Pinguim ();
                    pinguim.PinguimAnimal ();
                } else if (opcao == 8) {
                    Animais.TryGetValue (opcao, out string Animais8);
                    Console.WriteLine ($"Animal: {Animais8}");
                    Tartaruga tartaruga = new Tartaruga ();
                    tartaruga.TartarugaAnimal ();
                } else if (opcao == 9) {
                    Animais.TryGetValue (opcao, out string Animais9);
                    Console.WriteLine ($"Animal: {Animais9}");
                    Golfinho golfinho = new Golfinho ();
                    golfinho.GolfinhoAnimal ();
                } else {
                    Console.WriteLine ("OPÇÃO INVÁLIDA!");
                }
                // Console.Write("ATUALIZAR LISTA? [S/N]");
                // ListaAtual = char.Parse(Console.ReadLine());
                Console.WriteLine("=================================");

            // do {

                //REMOÇÃO DE NOMES DO MENU-----------------------------
                Console.WriteLine();
                Console.WriteLine("  LISTA ATUALIZADA");
                Console.WriteLine();
                Animais.Remove(opcao);

                foreach(var remover in Animais.Keys)
                {
                    Console.WriteLine(Animais[remover]);
                }
                
            // }while(ListaAtual == 'S');

                //----------------------------------------------------

                Console.WriteLine ();
                Console.Write ("CONTINUAR? [S/N] = ");
                SimNao = char.Parse (Console.ReadLine ().ToUpper ());
            } while (SimNao == 'S');

            Console.Clear ();

            Console.WriteLine ("CADASTRE NOVOS ANIMAIS:");
            Console.WriteLine ();
            Console.Write ("      [INFORME]");
            Console.WriteLine ();
            Console.WriteLine ();
            Console.Write ("Quantidade de animais:");
            int qtdAnimais = int.Parse (Console.ReadLine ());
            Console.WriteLine ();
            for (int i = 1; i <= qtdAnimais; i++) {
                Console.Write ($"{i}º ANIMAL: ");
                string animalNome = Console.ReadLine ();
                lista.Add (animalNome);
            }

            Console.WriteLine ();
            Console.WriteLine ("NOVOS ANIMAIS");
            Console.WriteLine ();
            int y = 0;
            foreach (var novosA in lista) {
                y++;
                Console.WriteLine ($"{y}º {novosA}");
            }

        }
        public static void AnimaisHabitat (Animal animalNome) {
            var classe = animalNome.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if((typeof(IAquatico).Equals(@interface)))
            {
                Console.WriteLine($"{classe}");
            }
            else if((typeof(IArboricula).Equals(@interface)))
            {
                Console.WriteLine("");
            }
            else if((typeof(IBranquiado).Equals(@interface)))
            {
                Console.WriteLine("");
            }
            else if((typeof(IQuionofilo).Equals(@interface)))
            {
                Console.WriteLine("");
            }
            else if((typeof(ITerrestre).Equals(@interface)))
            {
                Console.WriteLine("");
            }
            else if((typeof(IVoador).Equals(@interface)))
            {
                Console.WriteLine("");
            }
            

        }
    }
}