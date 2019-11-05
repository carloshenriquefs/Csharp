using System;
using System.Globalization;

namespace Nprodutos
{
    class ProdutosImporta : Produto
    {
        public double Alfandega { get; set; }

        public ProdutosImporta()
        {

        }

        public ProdutosImporta(string nome, double preco, double alfandega) :base (nome,preco)
        {
            this.Alfandega = alfandega;
        }


       public override string Etiqueta()
       {
           return Nome + " R$" + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) + "(Alfandega: R$ " + Alfandega.ToString("F2", CultureInfo.InvariantCulture) + ")";
       }

       public double PrecoTotal()
       {
           return Preco + Alfandega;
       }
    }
}
