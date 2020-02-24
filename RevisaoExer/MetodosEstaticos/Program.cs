using System;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Metodo com tipo primitivo
            CalculadoraEstatica somar = new CalculadoraEstatica();
            Console.WriteLine("Somar = {0} ",somar.Somar(2,2));

            //Metodo statico
            Console.WriteLine("Subtrair = {0} ",CalculadoraEstatica.Subtrair(3,5));

            //Metodo statico
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            Console.WriteLine("Multiplicar = {0}", resultado);

            //Metodo com tipo primitivo
            CalculadoraEstatica divisao = new CalculadoraEstatica();
            Console.WriteLine("Divisao = {0}",divisao.Divisao(10,2));

        }
    }
}
