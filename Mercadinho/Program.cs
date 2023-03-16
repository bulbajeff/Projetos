// See https://aka.ms/new-console-template for more information
using Mercadinho;

List<Produto> merca1 = new List<Produto>();
List<Produto> merca2 = new List<Produto>();
List<Produto> merca3 = new List<Produto>();

bool continua = true;

while (continua)
{
    Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
    string nomeProduto = Console.ReadLine();

    Console.WriteLine("Agora digite o valor do produto para o mercado 1: ");
    double precoProduto = int.Parse(Console.ReadLine());


    Console.WriteLine("Pressione S para continuar cadastrando ou N para encerrar");
    string resposta = Console.ReadLine();



    if(resposta == "N")
    {
        continua= false;
    }
}
