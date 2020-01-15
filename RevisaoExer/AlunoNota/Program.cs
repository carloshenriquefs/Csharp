using System;

namespace AlunoNota {
    class Program {
        //Fazer um programa para ler o nome de um aluno e as três notas que ele
        //ele obteve nos três trimestres do ano (primeiro trismestre vale 30 e o 
        // segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final 
        //do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e,
        //em caso negativo, quantos pontos faltam para o aluno obter o minimo para
        //ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para 
        //resolver este problema

        static void Main (string[] args) {
            Aluno desempenho = new Aluno ();

            Console.WriteLine ("[ ALUNO ]");
            Console.WriteLine ();
            Console.Write ("Nome do Aluno: ");
            string Nome = Console.ReadLine ();

            Console.Write ("Digite as três notas do aluno: ");
            desempenho.Nota1 = double.Parse (Console.ReadLine ());
            desempenho.Nota2 = double.Parse(Console.ReadLine());
            desempenho.Nota3 = double.Parse(Console.ReadLine());
            

            Console.Write ("Nota Final = " + desempenho.NotaFinal ());
            Console.WriteLine ();
            if (desempenho.Aprovado ()) {
                Console.WriteLine ("Aprovado!!");
            } else {
                Console.WriteLine ("Reprovado!!");
            }
        }
    }
}