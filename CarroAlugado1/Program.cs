using System;
using System.Globalization;
using CarroAlugado1.Entities;

namespace CarroAlugado1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("| Aluguel do Carro | ");
            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de Saida(dd/MM/yyyy) hh:ss): ");
            DateTime comeco = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de Chegada(dd/MM/yyyy hh:ss): ");
             DateTime final = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Preço por hora: ");
            Console.Write("Preço por dia:");
            Console.Write("INVOICE:");
            Console.Write("Pagamento Básico: ");
            Console.Write("Taxa: ");
            Console.Write("Pagamento Total: ");

            CarroAluguel carroalugado = new CarroAluguel(comeco, final, new Veiculo(modelo));
        }
    }
}
