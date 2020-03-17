using System.Globalization;

namespace ProdutosPolimorfismo.Entities
{
    public class ProdutosImportados : Produtos
    {
        public double Costumes { get; set; }

        public ProdutosImportados()
        {

        }

        public ProdutosImportados( string nomeprodutos,double costumes, double precoprodutos)
        :base( nomeprodutos,precoprodutos)
        {
            Costumes = costumes;
        }

        public double PrecoTotal()
        {
            return PrecoProdutos + Costumes;

        }
        public override string EtiquetaPreco()
        {
            return NomeProdutos + " $ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + Costumes.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}