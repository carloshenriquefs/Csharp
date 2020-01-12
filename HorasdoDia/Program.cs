using System;

namespace HorasdoDia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que horas são: ");
            double horas = double.Parse(Console.ReadLine());

            if(horas < 10){
                Console.WriteLine("Bom dia !");
            }
            else if(horas >= 12 && horas <= 18)
            {
                Console.WriteLine("Boa Tarde!!");
            }
            else{
                Console.WriteLine("Boa Noite");
            }
                
            
        }
    }
}
