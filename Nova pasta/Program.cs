using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            while(num > 0){
                if(num % 2 == 0)
                {
                    Console.WriteLine("O número {0} é PAR!",num);
                }
                else if(num % 2 == 1)
                {
                    Console.WriteLine("O número {0} é IMPAR!", num);   
                }
                else
                {
                    break;
                }

            }


          



            

        }
    }
}
