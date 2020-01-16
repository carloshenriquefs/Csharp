using System;
using System.Globalization;

namespace CotacaoDoDolar
{
    class Program
    {
        //Faça um programa para ler a cotação do dolar, e depois um valor
        //em dolares a ser comprado por uma pessoa em reais. Informar quantos
        //reais a pessoa vai pagar pelos dolares, considerando ainda que a pessoa
        //terá que pagar 6% de IOF sobre o valor em dolar. Criar um classe ConversorDeMoeda
        //para ser responsavel pelos calculos.
        static void Main(string[] args)
        {
            Console.Write("Informe a Cotação do Dolar: R$ ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você quer? R$ ");
            double quantiaDolar = double.Parse(Console.ReadLine());

            double cotacao = ConversorDeMoeda.DolarConversao(cotacaoDolar,quantiaDolar);

            Console.Write("Você pagará em reais: R$ "+cotacao.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
