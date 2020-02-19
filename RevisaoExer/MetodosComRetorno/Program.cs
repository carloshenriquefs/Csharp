using System;

namespace MetodosComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(4,3);
            var resultado1 = calculadoraComum.Subtrair(4,1);
            var resultado2 = calculadoraComum.Multiplicar(3,2);
            var resultado3 = calculadoraComum.Divisao(4,2);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);

        }
    }
}
