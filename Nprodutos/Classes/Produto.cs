using System;
using System.Globalization;

namespace Nprodutos
{
    class Produto
    {
        public string Nome { get; set; }
       public double Preco { get; set; }

       public Produto()
       {

       }

       public Produto(string nome, double preco)
       {
           this.Nome = nome;
           this.Preco = preco;
       }

       public virtual string Etiqueta()
       {
           return Nome + " R$ " + Preco.ToString("F2",CultureInfo.InvariantCulture);
       }
    }
}
