using System;
using System.Globalization;

namespace Horas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d8 = DateTime.Parse("15/08/2000");
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
           
            Console.WriteLine(date);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

        }
    }
}
