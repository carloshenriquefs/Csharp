namespace ClassePessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public double Idade { get; set; }

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos de idade!");
        }

        public void AprensetarConsole()
        {
            System.Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}