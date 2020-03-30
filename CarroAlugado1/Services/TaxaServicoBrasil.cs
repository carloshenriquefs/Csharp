namespace CarroAlugado1.Services
{
    public class TaxaServicoBrasil
    {
        public double Quantidade { get; set; }

        public double Taxa(double quantidade)
        {
            if(quantidade <= 100)
            {
                return quantidade *0.2;
            }
            else{
                return quantidade * 0.15;
            }
        }
    }
}