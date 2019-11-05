using System;

namespace NFiguras
{
    abstract class Area
    {
       public Color Color { get; set; }



        public Area(Color color)
        {
            this.Color = color;
        }

       public abstract double AreaFigura();
      
       
    }
}