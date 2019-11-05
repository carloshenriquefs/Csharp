using System;

namespace NFiguras
{
    class Retangulo : Area
    {
      public double Largura { get; set; } 
      public double Altura { get; set; }

    public Retangulo(double altura, double largura, Color color) : base(color)
    {
        this.Largura = largura;
        this.Altura = altura;
    }
        public override double AreaFigura()
        {
            return Altura * Largura;
        }
    }
}
