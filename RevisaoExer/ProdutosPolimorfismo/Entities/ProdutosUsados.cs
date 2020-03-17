using System;
using System.Globalization;

namespace ProdutosPolimorfismo.Entities
{
    public class ProdutosUsados : Produtos
    {
        public DateTime DataProducao { get; set; }

        public ProdutosUsados()
        {

        }

        public ProdutosUsados(string nomeprodutos, double precoprodutos,DateTime dataproducao)
        :base(nomeprodutos, precoprodutos)
        {
            DataProducao = dataproducao;
        }

        public override string EtiquetaPreco()
        {
            return NomeProdutos + " (used) $ " + PrecoProdutos.ToString("F2", CultureInfo.InvariantCulture) + "( Data: " + DataProducao.ToString("dd/mm/yy") + " ) ";
        }
    }
}