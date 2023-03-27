﻿using Mercadinho;
using System.Net;

List<Produto> produtos = new List<Produto>();

bool continua = true;
double total = 0;
double media = 0;
double soma = 0;
double[] totalMercado = new double[4];
int opcao = 0;


Console.WriteLine("Selecione 1 para incluir um novo produto.");
Console.WriteLine("");
Console.WriteLine("Selecione 2 para pesquisar um produto.");
Console.WriteLine("===================================================");
opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    while (continua)
    {
        Produto produto = new Produto();

        Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
        string nomeProduto = Console.ReadLine();
        produto.Nome = nomeProduto;


        Console.WriteLine("===================================================");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Agora digite os preços do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());
            produto.Preco[i] = precoProduto;
        }

        produtos.Add(produto);

        Console.WriteLine("===================================================");
        Console.WriteLine("Pressione S para voltar ao menu ou N para encerrar");
        string resposta = Console.ReadLine();

        if (resposta == "N")
        {
            continua = false;
        }

        Console.WriteLine("Selecione uma nova opção para continuar");
        opcao = 0;
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            continua = true;
        }

        if (opcao == 2)
        {
            continua = false;
        }
    }
}

for (int i = 0; i <= 3; i++)
{
    for (int j = 1; j <= produtos.Count; j++)
    {
        total = total + produtos[j - 1].Preco[i];
    }

    totalMercado[i] = total;

    total = 0;

    Console.WriteLine("O valor total do mercado " + (i + 1) + " é: " + "R$" + Math.Round(totalMercado[i], 2));
}

if (opcao == 2 && produtos.Count > 0)
{
    string nomeProduto = String.Empty;
    Console.WriteLine("=======================================");
    Console.WriteLine("Digite o nome do produto que deseja pesquisar");
    nomeProduto = Console.ReadLine();

    var resultadoNome = produtos.Find(n => n.Nome.Contains(nomeProduto));
    //var resultadoPreco = totalMercado.Find(totalMercado, p => p);
    var resultadoPreco = Array.Find(totalMercado, totalMercado[0]);
    Console.WriteLine(resultadoNome.Nome);
    Console.WriteLine(resultadoPreco.Preco[0]);
}
else
    Console.WriteLine("Opção incorreta ou nenhum produto adicionado.");



foreach (var item in produtos)
{
    Console.WriteLine(item.Nome);

    Console.WriteLine(item.Preco[0]);
    Console.WriteLine(item.Preco[1]);
    Console.WriteLine(item.Preco[2]);
    Console.WriteLine(item.Preco[3]);
}

Console.WriteLine("===================================================");

foreach (var item in produtos)
{
    soma = soma + item.Preco[produtos.Count];
    media = soma / produtos.Count();
    Console.WriteLine("O preço médio do item " + item.Nome + " é: " + "R$" + Math.Round(media, 2));
}



double controle = 0;

for (int i = 0; i < totalMercado.Length; i++)
{
    for (int j = i + 1; j < totalMercado.Length; j++)
    {
        if (totalMercado[i] > totalMercado[j])
        {
            controle = totalMercado[j];
            totalMercado[j] = totalMercado[i];
            totalMercado[i] = controle;
        }
    }
}

Console.WriteLine("Do mais barato para o mais caro: " +
    "{" + totalMercado[0] +
    "; " + totalMercado[1] +
    "; " + totalMercado[2] +
    "; " + totalMercado[3] +
    "}");

double percentual = 0;

percentual = (100 * totalMercado[0]) / totalMercado[3];

Console.WriteLine("A economia percentual do mercado mais caro para o mais barato é de: " + Math.Round(100 - percentual, 2) + "%");
