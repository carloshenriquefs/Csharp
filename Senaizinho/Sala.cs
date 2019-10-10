using System;

namespace Senaizinho
{
    class Sala
    {
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public int NumeroSala { get; set; }
        public string[] Alunos { get; set; }

        public Sala(int capacidadeTotal, int numeroSala)
        {
            this.CapacidadeTotal = capacidadeTotal;
            this.NumeroSala = numeroSala;
        }

        public string AlocarAluno(string nome)
        {
            
            // aluno[0] = Nome;
            // aluno[1] = Nome;
            // aluno[2] = Nome;
            // aluno[3] = Nome;
            // aluno[4] = Nome;
            // aluno[5] = Nome;
            // aluno[6] = Nome;
            // aluno[7] = Nome;
            // aluno[8] = Nome;
            // aluno[9] = Nome;

            for(i=0; i <10; i++)
            {
            Console.WriteLine("NOME DO ALUNO:");
            string Nome = Console.ReadLine();
            string[] aluno = new string[10]; 
            aluno[i] = Nome; 
            }            

            if ( fdg < 10)
            {
                return "CADASTRADO COM SUCESSO";
            }
            else
            {
                return "NÃO FOI POSSIVEL REGISTRAR O ALUNO";
            }
        }

        public string RemoverAluno(string nome)
        {
            Console.Write("QUANTIDADE DE ALUNOS DA SALA: ");
            int qtdAlunos = int.Parse(Console.ReadLine());
            CapacidadeTotal = qtdAlunos * 10;
            if (qtdAlunos > 100)
            {
                return "FORA DOS LIMITES DE ALUNOS";
            }
            else
            {
                return "INCLUA UM NOVO ALUNO";
            }
        }

        public string MostrarAlunos()
        {

        }

        
    }
}