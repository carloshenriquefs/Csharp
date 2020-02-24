namespace AtributosEstaticos
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produtos(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produtos()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
}