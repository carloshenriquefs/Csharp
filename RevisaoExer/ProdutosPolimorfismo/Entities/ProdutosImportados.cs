namespace ProdutosPolimorfismo.Entities
{
    public class ProdutosImportados : Produtos
    {
        public double Costumes { get; set; }

        public ProdutosImportados()
        {

        }

        public ProdutosImportados(double costumes, string nomeprodutos, double precoprodutos)
        :base( nomeprodutos,precoprodutos)
        {
            Costumes = costumes;
        }

        public override string EtiquetaPreco()
        {

        }

        public double PrecoTotal()
        {

        }
    }
}