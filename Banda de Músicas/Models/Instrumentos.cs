using System;
using System.Collections.Generic;


namespace Banda_de_Músicas.Models
{
    public class Instrumentos
    {
        string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        public  string TocarMusica()
        {
            int nota = new Random().Next(notas.Length -1);
            return notas[nota];
        }
    }
}