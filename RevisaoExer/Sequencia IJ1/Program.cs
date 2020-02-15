using System;

namespace Sequencia_IJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, j = 60;
            for(i = 1,j = 60;j<=60;i=i+3, j-=5)
            {
                Console.WriteLine($"I = {i} J= {j}");
                if(j == 0)
                    break;
            }
          
           
        }
    }
}
