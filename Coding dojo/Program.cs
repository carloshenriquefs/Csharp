using System;

namespace Coding_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            string simb = "*";
            double altura = 0;
            int quant = 0;
            
            Console.WriteLine("Informe a altura do triângulo:");
            altura = double.Parse(Console.ReadLine());
                                                                                                                                                                                                                                                                                                                        
            Console.WriteLine("Informe a quantidade de triângulos");
            quant = int.Parse(Console.ReadLine());

            for(int i = 0; i< quant;i++){
                string aster = "";
                for(int y = 0; y < altura; y++)
                {
                    Console.WriteLine(aster = simb + aster); 
                }
                Console.WriteLine(" ");
            }
        }
    }
}
