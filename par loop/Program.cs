using System;

namespace par_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 1;
            while(num != 0){
                
                Console.WriteLine("=============");
                Console.WriteLine("PAR / IMPAR");
                Console.WriteLine("==============");
                Console.WriteLine("Informe um número: ");
                num = int.Parse(Console.ReadLine());
                
                if(num != 0){
                    if(num % 2 == 0)
                    {
                        Console.WriteLine("O número {0} é PAR!",num);
                    }
                    else if(num % 2 == 1)
                    {
                        Console.WriteLine("O número {0} é IMPAR!", num);   
                    }
                }
                
            }
        }
                
    }
}
