using System;

namespace SpanTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t1.Add(t2);
            TimeSpan diferenca = t1.Subtract(t2);
            TimeSpan multiplica = t2.Multiply(2);
            TimeSpan divisao = t2.Divide(2);

            Console.WriteLine(soma);
            Console.WriteLine(diferenca);
            Console.WriteLine(multiplica);
            Console.WriteLine(divisao);
        }
    }
}
