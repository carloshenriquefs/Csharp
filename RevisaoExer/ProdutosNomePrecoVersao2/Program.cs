using System;

namespace ProdutosNomePrecoVersao2 {
    class Program {
        //Fazer um programa para ler um número inteiro N e os dados (Nome e Preco)
        //de N produtos. Armazene os N produtos em um vetor. Em seguida, mostrar
        // o preco médio dos produtos.

        static void Main (string[] args) {

            Console.WriteLine ("PRODUTOS - VERSAO2");
            Console.WriteLine ();

            Console.WriteLine ("Informe a quantidade de produtos: ");
            int qtdProdutos = int.Parse (Console.ReadLine ());

            Produto[] vetor = new Produto[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++) {
                string nomeProduto = Console.ReadLine ();
                double precoProduto = double.Parse (Console.ReadLine ());
                vetor[i] = new Produto { Nome = nomeProduto, Preco = precoProduto };
            }

            double soma = 0;
            for (int i = 0; i < qtdProdutos; i++) {
                //soma = soma + vetor[i].Preco;
                soma += vetor[i].Preco;
            }

            double media = soma / qtdProdutos;

            Console.WriteLine ("Media = {0}", media);
        }
    }
}