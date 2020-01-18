using System;

namespace PensionatoQuartos {
    class Program {
        //A dona de um pensionato possui dez quartos para alugar para estudantes,
        //sendo esses quartos identificados pelos numeros 0 a 9
        //Fazer um programa que inicie com todos os dez quartos vazios, e depois
        //leia uma quantidade N representando o número de estudantes que vão alugar
        //quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes
        //Para cada registro de aluguel, informar o nome e email do estudante, bem como
        // qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto
        //vago. Ao final, seu programa deve imprimir um relatorio de todas ocupações do
        //pensionato, por ordem de quarto
        static void Main (string[] args) {
            Console.WriteLine ();
            Console.WriteLine ("    [ PENSIONATO ]");
            Console.WriteLine ();

            Estudante[] quartos = new Estudante[10];

            Console.Write("Informe a quantidade de quartos: ");
            int qtdEstudante = int.Parse (Console.ReadLine ());

            for (int i = 1; i <= qtdEstudante; i++) {
                Console.WriteLine ("Estudante #:" + i);
                Console.Write ("Nome: ");
                string nomeEstudante = Console.ReadLine ();
                Console.Write ("Email: ");
                string emailEstudante = Console.ReadLine ();
                Console.Write("Escolha um quarto de: [0 a 9] - ");
                int quartoNumero = int.Parse (Console.ReadLine ());
                quartos[quartoNumero] = new Estudante(nomeEstudante, emailEstudante);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            Console.WriteLine();
            for(int i = 0; i < 10; i++)
            {
                if (quartos[i] != null) 
                {
                    Console.WriteLine(i+ " Quarto : #{0}", quartos[i]+" - | OCUPADO |");
                }

            }
             
        }
    }
}