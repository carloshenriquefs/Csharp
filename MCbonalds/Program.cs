using System;

namespace MCbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Clientes cliente1 = new Clientes("Ronaldo", "122421423", "manguinhaassassina@gmail.com");
            Console.WriteLine("Nome: "+cliente1.Nome);
            Console.WriteLine("Telefone: "+ cliente1.Telefone);
            Console.WriteLine("Email: "+cliente1.Email);
            

        }
    }
}
