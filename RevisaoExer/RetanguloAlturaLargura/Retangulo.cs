using System;

namespace RetanguloAlturaLargura
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura + Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura) + (Altura * Altura);
        }
    }
}