namespace BancoSaqueDeposito
{
    public class Banco
    {
        public int numeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Banco(){

        }

        public Banco(int numeroconta, string nometitular)
        {
            this.numeroConta = numeroconta;
            this.NomeTitular = nometitular;
        }
        public Banco(int numeroconta, string nometitular, double saldo){
            this.numeroConta = numeroconta;
            this.NomeTitular = nometitular;
            this.Saldo = saldo;
        }

        public void Deposito(double quantia){
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia){
            Saldo -= quantia + 5;
        }

        public override string ToString(){
            return numeroConta + " Titular: "+ NomeTitular + ", Saldo: R$" + Saldo;
        }

        public double DepositoBanco(int deposito)
        {
            double TotalDeposito =  Saldo + deposito;
            return TotalDeposito;
        }
    }
}