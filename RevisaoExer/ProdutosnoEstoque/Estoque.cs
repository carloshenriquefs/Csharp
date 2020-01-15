using System;
using System.Globalization;

namespace ProdutosnoEstoque
{
    public class Estoque
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public double ValorTotalEmEstoque(){
            double totalEstoque = Preco * QuantidadeEstoque;
            return totalEstoque;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + QuantidadeEstoque + " unidade, Total em Estoque: R$ " + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture) ; 
        }

        public void AdicionarProdutos(int quantidade)
        {
            QuantidadeEstoque = QuantidadeEstoque + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            QuantidadeEstoque = QuantidadeEstoque - quantidade;
        }


    }
}