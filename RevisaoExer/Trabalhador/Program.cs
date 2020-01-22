using System;
using Trabalhador.Enum;
namespace Trabalhador
{
    class Program
    {
        //Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário).
        //Depois, solicitar do usuario um mês e mostrar qual foi o salário do funcionário
        //nesse mês
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Insira as informações: ");
            Console.Write("Nome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Nivel (JUNIOR/MIDLEVEL/SENIOR): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salarial: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Quantos contratos ?");
            int numContratos = int.Parse(Console.ReadLine());

            for(int i = 0; i < numContratos; i++)
            {
                Console.Write(i+1+ "# Contrato - [INFORMAÇÕES]");
                Console.Write("Data (DD/MM/YYYY): ");
                string data = Console.ReadLine();
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas):");
                double duracaoHoras = double.Parse(Console.ReadLine());
            }

            Console.Write("Informar o mês para o calculo (MM/YYYY): ");
            string dataCalculo = Console.ReadLine();

        }
    }
}
