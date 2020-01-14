using System;

namespace FuncionarioHorasTrabalhadas
{
    class Program
    {
        //Fazer um programa que leia o número de um Funcionário, seu número
        //de horas trabalhadas, o valor que recebe por hora e calcula o salário
        //desse funcionário. A seguir, mostre o número e o salário do funcionário,
        // com duas casas decimais
        static void Main(string[] args)
        {
            Console.WriteLine(" [ FUNCIONARIO - SALÁRIO ]");
            Console.WriteLine();
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Horas Trabalhadas: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.Write("Quanto recebe:  R$ ");
            double rebeporHoras = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * rebeporHoras;
            Console.WriteLine("ID: {0}",id);
            Console.Write("Salário: R${0}",salario);

        }
    }
}
