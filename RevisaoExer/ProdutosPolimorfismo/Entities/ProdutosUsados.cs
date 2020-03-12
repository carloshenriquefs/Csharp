using System;

namespace ProdutosPolimorfismo.Entities
{
    public class ProdutosUsados : Produtos
    {
        public DateTime DataProducao { get; set; }

        public ProdutosUsados()
        {

        }

        public ProdutosUsados(DateTime dataproducao)
        :base(nomeprodutos, precoprodutos)
        {
            DataProducao = dataproducao;
        }

        public override string EtiquetaPreco()
        {

        }
    }
}