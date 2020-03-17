using System.Globalization;

namespace ProdutosPolimorfismo
{
    public class Produtos
    {
        public string NomeProdutos { get; set; }
        public double PrecoProdutos { get; set; }

        public Produtos()
        {

        }

        public Produtos(string nomeprodutos, double precoprodutos)
        {
            NomeProdutos = nomeprodutos;
            PrecoProdutos = precoprodutos;
        }
        public virtual string EtiquetaPreco()
        {
            return NomeProdutos + " $ " + PrecoProdutos.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}