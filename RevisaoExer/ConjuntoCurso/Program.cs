using System;
using System.Collections.Generic;

namespace ConjuntoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos: ");
            int alunosA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for(int i = 0; i < alunosA; i++)
            {
                int codigosA = int.Parse(Console.ReadLine());
                cursoA.Add(codigosA);
            }

            Console.WriteLine();
            Console.Write("O curso B possui quantos alunos: ");
            int alunosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for(int j = 0; j < alunosB; j++)
            {
                int codigoB = int.Parse(Console.ReadLine());
                cursoB.Add(codigoB);
            }

            Console.WriteLine();
            Console.Write("O curso C possui quantos alunos: ");
            int alunosC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for(int y = 0; y < alunosC; y++)
            {
                int codigoC = int.Parse(Console.ReadLine());
                cursoC.Add(codigoC);
            }
           
           Console.WriteLine();
           HashSet<int> Novo = new HashSet<int>();
           Novo.UnionWith(cursoA);
           Novo.UnionWith(cursoB);
           Novo.UnionWith(cursoC);
           Console.WriteLine("Total de Alunos: "+Novo.Count);

        }
    }
}
