using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using FuncionariosCSV_Exerc.Entities;

namespace FuncionariosCSV_Exerc {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Enter full file path: ");
            string path = Console.ReadLine ();
            Console.Write ("Enter Salary: ");
            double salario = Double.Parse (Console.ReadLine (),CultureInfo.InvariantCulture);

            List<Funcionario> list = new List<Funcionario> ();

            try {
                using (StreamReader sr = File.OpenText (path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine ().Split (',');
                        string nome = fields[0];
                        string email = fields[1];
                        double salarioFunc = double.Parse (fields[2], CultureInfo.InvariantCulture);
                        list.Add (new Funcionario (nome, email, salarioFunc));
                    }

                    var emails = list.Where (p => p.Salario > salario).OrderBy (p => p.Email).Select (p => p.Email);

                    var soma = list.Where (p => p.Nome[0] == 'M').Sum (p => p.Salario);

                    Console.WriteLine ("Email de pessoas com salario maior que R$2000.00" + salario.ToString ("F2", CultureInfo.InvariantCulture));
                    foreach (string email in emails) {
                        Console.WriteLine (email);
                    }

                    Console.WriteLine ("Soma dos salarios com pessoas com letra 'M': " + soma.ToString ("F2", CultureInfo.InvariantCulture));
                }
            } catch (IOException e) {
                Console.WriteLine ("An error occurred");
                Console.WriteLine (e.Message);
            }
        }
    }
}