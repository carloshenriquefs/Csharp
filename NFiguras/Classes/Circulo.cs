using System;

namespace NFiguras
{
    class Circulo : Area
    {
       public double Raio { get; set; }
       

       public Circulo(double raio,Color color) : base(color)
       {
           this.Raio = raio;
       }

        public override double AreaFigura()
        {
            return Math.PI * Raio * Raio;
        }
    }
}