using System;

namespace CotacaoDoDolar
{
    public class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double DolarConversao(double cotacaoDolar, double quantiaDolar)
        {
            double total =  cotacaoDolar * quantiaDolar;
            return total + (total * IOF); 
        }
    }
}