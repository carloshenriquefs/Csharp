using System;
using System.Collections.Generic;
using ReciclagemLixo.interfaces;
using ReciclagemLixo;

namespace ReciclagemLixo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================");
            Console.WriteLine("   RECICLAGEM");
            Console.WriteLine("================");
            Console.WriteLine();
            // Console.WriteLine("      MENU");
            // Console.WriteLine();
            // Console.WriteLine("[1] - PAPEL:");
            // Console.WriteLine("[2] - PLÁSTICO:");
            // Console.WriteLine("[3] - VIDRO:");
            // Console.WriteLine("[4] - METAL:");
            // Console.WriteLine("[5] - ORGÂNICO: ");
            // Console.WriteLine("[0] - NÃO RECICLÁVEL:");
            // Console.WriteLine();
            // Console.WriteLine("Escolha uma opção:");
            // int opcao = int.Parse(Console.ReadLine());
            // Console.WriteLine();

            Console.WriteLine("  MENU - MATERIAL");
            Console.WriteLine();
            Console.WriteLine("[1] - GARRAFA:");
            Console.WriteLine("[2] - GARRAFAPET:");
            Console.WriteLine("[3] - GUARDACHUVA:");
            Console.WriteLine("[4] - LATINHA:");
            Console.WriteLine("[5] - PAPELÃO:");
            Console.WriteLine("[6] - POTE DE MANTEIGA:");
            Console.Write("ESCOLHA UM MATERIAL PARA RECICLAGEM:");
            int opcao1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(opcao1)
            {
                case 1:
                Console.WriteLine("1 - GARRAFA:");
                GarrafaVidro nome = new GarrafaVidro();
                nome.VerdVidro();
                Console.WriteLine();
                GarrafaVidro adicionar = new GarrafaVidro();
                adicionar.Adicionar();
                
                break;

                case 2:
                Console.WriteLine("2 - GARRAFAPET:");
                GarrafaPET nome1 = new GarrafaPET();
                nome1.GarrafaVermelha();
                break;

                case 3:
                Console.WriteLine("3 - GUARDACHUVA:");
                GuardaChuva nome7 = new GuardaChuva();
                nome7.AmareloMetal();
                break;

                case 4:
                Console.WriteLine("4 - LATINHA:");
                LatinhaMetal nome2 = new LatinhaMetal();
                nome2.AmareloMetal();
                break;

                case 5:
                Console.WriteLine("5 - PAPELÃO:");
                PapelaoPapel nome3 = new PapelaoPapel();
                nome3.AzulPapel();
                break;

                case 6:
                Console.WriteLine("6 - POTE DE MANTEIGA:");
                PoteManteigaPlastico nome4 = new PoteManteigaPlastico();
                nome4.VermelhoPlastico();
                break;

                case 7:
                Console.WriteLine("7 - MANTEIGA:");
                ManteigaOrgânico nome5 = new ManteigaOrgânico();
                nome5.MarromOrganico();
                break;

                default:
                Console.WriteLine("Opção Inválida!");
                break;

            }

        }
    }
}
