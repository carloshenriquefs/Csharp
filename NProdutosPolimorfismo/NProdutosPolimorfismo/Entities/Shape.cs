using NProdutosPolimorfismo.Entities.Enum;

namespace NProdutosPolimorfismo.Entities
{
     abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {

            Color = color;
        }

        public abstract double Area();
      
    }
}
