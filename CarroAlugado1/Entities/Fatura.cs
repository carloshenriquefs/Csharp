using System.Globalization;

namespace CarroAlugado1.Entities
{
    public class Fatura
    {
        public double PagamentoBasico { get; set; }

        public double Taxa { get; set; }

        public Fatura(double pagamentobasico, double taxa)
         { 
             PagamentoBasico = pagamentobasico;
             Taxa = taxa;
         }

         public double PagamentoTotal{
             get {return PagamentoBasico + Taxa;}
         }

         public override string ToString(){
             return "Pagamento basico: " 
             + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
             + "\nTaxa: "
             + Taxa.ToString("F2", CultureInfo.InvariantCulture)
             + "\nPagamento Total: "
             +PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
         }
    }
}