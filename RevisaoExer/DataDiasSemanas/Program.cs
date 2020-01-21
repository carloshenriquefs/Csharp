using System;

namespace DataDiasSemanas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            DateTime d1 = d.AddHours(2);
            DateTime d2 = d.AddMinutes(3);
            DateTime d3 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine("1) Date:" +d.Date);
            Console.WriteLine("2) Day:"+d.Day);
            Console.WriteLine("3) DayOfWeek: "+d.DayOfWeek);
            Console.WriteLine("4) DayofYear: "+d.DayOfYear);
            Console.WriteLine("5) Hour:"+d.Hour);
            Console.WriteLine("6) Kind: "+d.Kind);
            Console.WriteLine("7) Milisecond: "+d.Millisecond);
            Console.WriteLine("8) Minute: "+d.Minute);
            Console.WriteLine("9) Month: "+d.Month);
            Console.WriteLine("10) Second: "+d.Second);
            Console.WriteLine("11) Ticks: "+d.Ticks);
            Console.WriteLine("12) TimeOfDay: "+d.TimeOfDay);
            Console.WriteLine("13) Year: "+d.Year);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("Diferença de dias:");
            DateTime data1 = new DateTime(2000, 10, 15);
            DateTime data2 = new DateTime(2000, 10, 18);

            TimeSpan diferenca = data2.Subtract(data1);

            Console.WriteLine(diferenca);
            
        }
    }
}
