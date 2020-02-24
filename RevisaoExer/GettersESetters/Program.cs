using System;

namespace GettersESetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto("Kawasaki", "Ninja ZX-6R",636);
            Console.WriteLine(moto.GetMarca());
            Console.WriteLine(moto.GetModelo());
            Console.WriteLine(moto.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-154);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}
