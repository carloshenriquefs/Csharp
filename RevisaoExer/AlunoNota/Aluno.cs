namespace AlunoNota
{
    public class Aluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante(double Falta)
        {
            return Falta = 60 - NotaFinal();
        }
    }
}