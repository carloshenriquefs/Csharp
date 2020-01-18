namespace PensionatoVersao2
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string  Email { get; set; }

        public Aluno(){

        }

        public Aluno(string nome, string email){
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}