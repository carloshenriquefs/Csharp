using System;
using System.Globalization;

namespace DadosFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            Salario = Salario - Imposto;
            return Salario;
        }

        public override string ToString()
        {
            return Nome + ", " + " R$" + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem/100) ;
        }
    }
}