namespace Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, double salario)
        {
            this.ID = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void SalarioAumento(double porcentagem)
        {
            
        }
    }
}