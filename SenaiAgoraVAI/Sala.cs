using System;

namespace SenaiAgoraVAI
{
    class Sala
    {
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public int NumeroSala { get; set; }
        public string[] Alunos { get; set; }

        public Sala(int numeroSala, int capacidadeTotal)
        {
            this.NumeroSala = numeroSala;
            this.CapacidadeTotal = capacidadeTotal;
        }

        public string AlocarAluno()
        {

        }

        public RemoverAluno()
        {

        }

        public string MostrarAlunos()
        {

        }
    }
}
