using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmpresaPOLI {
    class Program {
        //Uma empresa possui funcionários próprios e terceirizados.
        //Para cada funcionário, deseja-se registrar nome, horas trabalhadas
        //e valor por hora. Funcionários terceirizado possuem ainda
        //uma despesa adicional

        //O pagamento dos funcionários corresponde ao valor da hora
        //multiplicado pelas horas trabalhadas, sendo que os funcionários
        //terceirizados ainda recebem um bônus correspondente a 110% 
        //de sua despesa adicional

        //Fazer um programa para ler os dados de N funcionarios 
        //(N fornecido pelo usuário) e armazená-los em uma lista. Depois
        //de ler todos os dados, mostrar nome e pagamento de cada 
        //funcionario na mesma ordem em que foram digitados.
        static void Main (string[] args) {
            List<Funcionarios> lista = new List<Funcionarios> ();

            Console.WriteLine ();
            Console.WriteLine ("================================");
            Console.WriteLine ("    EMPRESA - TERCEIRIZADA");
            Console.WriteLine ("================================");
            Console.WriteLine ();

            Console.WriteLine ("Quantidade de funcionarios: ");
            int numeroFunci = int.Parse (Console.ReadLine ());
            Console.WriteLine ();
            for (int i = 1; i <= numeroFunci; i++) {
                Console.WriteLine ("Funcionário: " + i);
                Console.Write ("Terceirizado: [S/N] ? ");
                string SimNao = Console.ReadLine ().ToUpper ();
                Console.WriteLine ();
                Console.Write ("Nome: ");
                string nome = Console.ReadLine ();
                Console.Write ("Horas: ");
                int horas = int.Parse (Console.ReadLine ());
                Console.Write ("Valor por Horas: ");
                double valorporhoras = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
                if (SimNao == "S") {
                    Console.WriteLine ("Cobrança Adicional: ");
                    double cobrancaadicional = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
                    lista.Add (new FuncionarioTerceirizado (nome, horas, valorporhoras, cobrancaadicional));
                } else {
                    lista.Add(new Funcionarios(nome, horas,valorporhoras));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach(Funcionarios func in lista)
            {
                Console.WriteLine(func.Nome + " - "+ func.FormadePagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}