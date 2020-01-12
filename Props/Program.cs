using System;

namespace Props
{
    class Program
    {
        public class CarroOpcional{
            double desconto = 0.1;

            string nome;
            public string Nome{
                get{
                    return "Opcional: " + nome;
                }
                set{
                    nome = value;
                }
            }

            public double Preco {get; set;}

            public double PrecoComDesconto{
                get => Preco - (desconto * Preco);
            }

            public CarroOpcional(){

            }

            public CarroOpcional(string nome, double preco)
            {
                this.nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var carro1 = new CarroOpcional("Ar Condicionado!", 2345.99);
            Console.WriteLine(carro1.PrecoComDesconto);

            // carro1.PrecoComDesconto = 3000;

            var carro2 = new CarroOpcional();
            carro2.Nome = "Direção Elétrica";
            carro2.Preco = 2365.25;

            Console.WriteLine(carro1.Nome);
            Console.WriteLine(carro1.Preco);
            Console.WriteLine(carro2.Nome);
            Console.WriteLine(carro2.Preco);
        }
    }
}
