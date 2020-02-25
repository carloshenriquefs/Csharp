using System;

namespace Delegates2
{
    class Program
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);
        static void Main(string[] args)
        {
            Soma op1 = UsandoDelegate.MinhaSoma;
            Console.WriteLine(op1(2,3.9));

            ImprimirSoma op2 = UsandoDelegate.MenuImprimirSoma;
            op2(5,8);

            // Func<double, double, double> op3 = UsandoDelegate.MinhaSoma;
            // Console.WriteLine(op3(2.5,3));

          
        }
    }
}
