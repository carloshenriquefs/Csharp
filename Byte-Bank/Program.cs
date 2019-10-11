using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("     BYTE-BANK");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("Cadastro de clientes:");
            Console.WriteLine();
            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);
            //Cliente.nome ="";
            //Cliente.Cliente(cpf);
            //Cliente.Cliente(email);
            // Cliente.Cliente(nome);
            // Cliente.Cliente(cpf);
            // Cliente.Cliente(email);

            bool senhaOk = false;

            do
            {
                Console.WriteLine("Digite a senha:");
                string senha = Console.ReadLine();
                senhaOk = cliente1.TrocaSenha(senha);

                if(!senhaOk)
                {
                    Console.WriteLine("Senha não atende aos Requisitos!");
                }
                else
                {
                    Console.WriteLine("Senha Trocada com Sucesso!");
                }
            }while(!senhaOk);

            Console.WriteLine();
            Console.WriteLine("Número da Agência:");
            int agencia = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Número da Conta:");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool saldoOk = false;
            double saldo;

            do
            {
                Console.WriteLine("Saldo: ");
                saldo = double.Parse(Console.ReadLine());

                if(saldo > 0)
                {
                    saldoOk = true;
                }
                else
                {
                    Console.WriteLine("Saldo Invalido!");
                }
            }while(!saldoOk);

            ContaCorrente contaCorrente = new ContaCorrente(agencia, conta, cliente1);
            //contaCorrente.Saldo = saldo;
            contaCorrente.Deposito(saldo);
            contaCorrente.Agencia = 123;
            
            //DEPOSITO

             Console.WriteLine("DEPOSITO");
             Cliente usuario = contaCorrente.Titular;
             Console.WriteLine($"Bem-Vindo: {usuario.nome}");
             Console.WriteLine($"Agencia: {contaCorrente.Agencia} Conta: {contaCorrente.Numero}");
             Console.WriteLine($"Saldo: {contaCorrente.saldo}");
             Console.WriteLine("Digite o valor do depósito: R$");
             double valor = double.Parse(Console.ReadLine());
             contaCorrente.Deposito(valor);
             Console.WriteLine();


            //SAQUE

             Console.WriteLine("SAQUE");
             Console.WriteLine($"Bem-vindo {usuario.nome}");
             Console.WriteLine($"Agência {contaCorrente.Agencia}");
             Console.WriteLine($"Saldo: R$ {contaCorrente.saldo}");
             Console.WriteLine("Valor de Saque: R$");
             double saque = double.Parse(Console.ReadLine());
             if(contaCorrente.Saque(valor))
             {
                 Console.WriteLine("Retire as notas abaixo");
             }
             else
             {
                 Console.WriteLine("Saque invalido!!!");
             }
             Console.WriteLine($"Saldo Atual: R${contaCorrente.saldo}");

             Cliente cliente2 = new Cliente("Carlos","123.659.569.21","CarlosTheman@gmail.com");
            //  cliente2.Senha = "123";
            //  cliente2.nome = "teste";
             ContaCorrente contaCorrente2 = new ContaCorrente(123,256,cliente2);
             Console.WriteLine("TRANSFERÊNCIA");
             Console.WriteLine($"Bem Vindo: {usuario.nome}");
             Console.WriteLine($"Agencia: {contaCorrente.Agencia}");
             Console.WriteLine($"Saldo Origem: R${contaCorrente.saldo}");
             Console.WriteLine($"Saldo Destino: R${contaCorrente2.saldo}");
             Console.WriteLine("Valor à ser transferido: R$");
             valor = double.Parse(Console.ReadLine());

             if(contaCorrente.Transferencia(contaCorrente2, valor))
             {
                 Console.WriteLine("Transferência Efetuada");
             }
             else
             {
                 Console.WriteLine("Transferência não efetuada!!!");
             }

             //CPF

            bool cpfcerto = false;

           do
           {
               Console.WriteLine("Informe o seu CPF:");
               cpf = Console.ReadLine();
               cpfcerto = cliente1.CPF(cpf);

               if(!cpfcerto)
               {
                   Console.WriteLine("CPF INVALIDO!!!");
               }
               else
               {
                   Console.WriteLine("CPF VALIDO!!!");
               }

           }while(!cpfcerto);
        
        }
    }
}
