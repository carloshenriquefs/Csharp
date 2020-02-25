using System;

namespace Readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987,5,26));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
