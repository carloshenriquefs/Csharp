namespace PropriedadesGetSet
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome{
            get{
                return "Opcional: "+ nome;
            }
            set{
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto{
            get => Preco - (desconto * Preco);
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}