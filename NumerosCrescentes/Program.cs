using System;

namespace NumerosCrescentes {
    class Program {
        static void Main (string[] args) {
            
            int num0 = 0;

            Console.WriteLine("ORDEM CRESCENTE");
            // for(int i = 0; i< 3;i++)
            // {
            //     Console.WriteLine("Informe o"+ (i+1)+"número:");
            //     int numero = int.Parse(Console.ReadLine());
            // }
            Console.WriteLine();
            Console.WriteLine("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                num0 = num1;
                num1 = num2;
                num2 = num0;
            }

            if(num1 > num3)
            {
                num0 = num1;
                num1 = num3;
                num3 = num0;
            }

            if(num2 > num3)
            {
                num0 = num2;
                num1 = num3;
                num3 = num0;
            }

            Console.WriteLine("Ordem Crescente: "+num1+","+num2+","+num3);
           
        }
    }
}