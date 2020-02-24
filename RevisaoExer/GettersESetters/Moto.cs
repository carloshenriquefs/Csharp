namespace GettersESetters
{
    public class Moto
    {
        public string Marca;
        public string Modelo;
        public int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            if(cilindrada > 0)
            {
                Cilindrada = cilindrada;
            }

            Cilindrada = Math.Abs(cilindrada);
        }

    }

}