using System;

namespace String___funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            string frase = "abcd EFGH ijkl MNOP abcd EFGH ijkl MNOP";
            string maiusculo = frase.ToUpper(); //MAIUSCULO
            string minusculo = frase.ToLower(); //MINUSCULO
            string sem_Espaço = frase.Trim();   //SEM ESPAÇO

            int procurar = frase.IndexOf("bc"); //PROCURA BC, a primeira ocorrencia b
            int procurar1 = frase.LastIndexOf("bc"); //PROCURA BC a ultima ocorrencia c

            string comecaIndice = frase.Substring(3); //Começa a partir do indice 3
            string comecaIndiceCorte = frase.Substring(3,5); //Começa a partir do indice 3 e mais 5 caracteres

            string substituir = frase.Replace('a' , 'x'); //Troca o caracter a pelo x
            string trocarLetra = frase.Replace("abc", "xy"); //Troca as letras abc por xy

            bool conteudoNullo = string.IsNullOrEmpty(frase); //Verificar se conteudo é vazio
            bool vaziaEespacoemBranco = string.IsNullOrWhiteSpace(frase); //Espaço em branco

            Console.WriteLine("Frase Original: -"+frase+"-");
            Console.WriteLine("Frase em Maiusculo: -"+maiusculo+"-");
            Console.WriteLine("Frase em Minusculo: -" +minusculo+"-");
            Console.WriteLine("Sem espaço: -"+ sem_Espaço +"-");
            Console.WriteLine("IndexOf('bc') = b:"+ procurar); 
            Console.WriteLine("LastIndexOf ('bc') = c:"+procurar1);
            Console.WriteLine("Substring:" + comecaIndice);
            Console.WriteLine("Substring: "+comecaIndiceCorte);
            Console.WriteLine("Replace ('a', 'x'): -"+substituir +"-");
            Console.WriteLine("Replace ('abc', 'xy'): -"+ trocarLetra +"-");
            Console.WriteLine("IsNullOrEmpty: " + conteudoNullo);
            Console.WriteLine("IsNullOrWhiteSpace: "+ vaziaEespacoemBranco);

        }
    }
}
