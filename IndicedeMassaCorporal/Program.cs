using System;

namespace IndicedeMassaCorporal
{
    class Program
    {
        //16. Um endocrinologista deseja controlar a saúde de seus pacientes e, 
        //para isso, se utiliza do Índice de Massa Corporal (IMC). Sabendo-se que 
        //o IMC é calculado através da seguinte fórmula:
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("ÍNDICE DE MASSA CORPORAL (IMC)");
            Console.WriteLine();
            Console.WriteLine("INFORME");
            Console.WriteLine();
            Console.Write("PESO:");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("ALTURA:");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / altura*altura;

            Console.WriteLine("IMC = "+IMC+"kg");

            if(IMC <= 20)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if(IMC >= 20 && IMC <= 25)
            {
                Console.WriteLine("Normal!");
            }
            else if(IMC >= 25 && IMC <= 30)
            {
                Console.WriteLine("Excesso de peso!");
            }
            else if(IMC >= 30 && IMC <= 35)
            {
                Console.WriteLine("Obesidade!");
            }
            else if(IMC > 35)
            {
                Console.WriteLine("Obesidade Mórbida!");
            }
        }
    }
}
