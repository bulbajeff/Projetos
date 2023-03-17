using Mercadinho;

List<Produto> produtos = new List<Produto>();

bool continua = true;
double somaMercado = 0;
double media = 0;

while (continua)
{
    Produto produto = new Produto();
    
    Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
    string nomeProduto = Console.ReadLine();
    produto.Nome = nomeProduto;

    Console.WriteLine("===================================================");
    for (int i = 0; i <= 2; i++)
    {
        Console.WriteLine("Agora digite os preços do produto: ");
        double precoProduto = double.Parse(Console.ReadLine());
        produto.Preco[i] = precoProduto;      
    }
    
    produtos.Add(produto);
    Console.WriteLine("===================================================");
    Console.WriteLine("Pressione S para continuar cadastrando ou N para encerrar");
    string resposta = Console.ReadLine();
        
    if(resposta == "N")
    {
        continua = false;
    } 
}

    foreach(var item in produtos)
    {
        Console.WriteLine(item.Nome);

        Console.WriteLine(item.Preco[0]);
        Console.WriteLine(item.Preco[1]);
        Console.WriteLine(item.Preco[2]);
    }

    Console.WriteLine("===================================================");

    foreach (var item in produtos)
    {
        media = (item.Preco[0] + item.Preco[1] + item.Preco[2])/3;
        Console.WriteLine("O preço médio do item " + item.Nome +  " é: " + media);
    }

    foreach(var item in produtos)
    {
        
    }


