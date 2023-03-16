using Mercadinho;

List<Produto> merca1 = new();
List<Produto> merca2 = new();
List<Produto> merca3 = new();

bool continua = true;

while (continua)
{
    Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
    string nomeProduto = Console.ReadLine();

    Console.WriteLine("Agora digite o valor do produto para o mercado 1: ");
    double precoProduto = double.Parse(Console.ReadLine());

     
    

    Console.WriteLine("Pressione S para continuar cadastrando ou N para encerrar");
    string resposta = Console.ReadLine();
    
    


    if(resposta == "N")
    {
        continua = false;
    }
}
