using System;

namespace TelefoneAgenda {
    class Registro {
        
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Aniversario { get; set; }

        public Registro(string nome, string telefone, string aniversario)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Aniversario = aniversario;
        }

        public Registro(){

        }

        public void QuantidadePessoas()
        {
            Console.Write("Quantidade de Pessoas: ");
            int quantPessoas = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantPessoas; i++)
            {
                Console.Write("NOME: ");
                string Nome = Console.ReadLine();
                Console.Write("TELEFONE: ");
                string telefone = Console.ReadLine();
                Console.Write("ANIVERSÁRIO: ");
                string aniversario = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}