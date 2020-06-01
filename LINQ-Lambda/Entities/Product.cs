using System.Globalization;

namespace LINQ_Lambda.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Category Category { get; set; }

        public override string ToString(){
            return Id + ", " + Nome + ", " + Preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + Category.Nome + Category.Tier;
        }
    }
}