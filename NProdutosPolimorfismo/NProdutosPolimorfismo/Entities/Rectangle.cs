using System;
using System.Collections.Generic;
using NProdutosPolimorfismo.Entities.Enum;
using System.Linq;
using System.Threading.Tasks;

namespace NProdutosPolimorfismo.Entities
{
    class Rectangle : Shape
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Rectangle(double largura, double altura, Color color) : base(color)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
