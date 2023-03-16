Console.WriteLine(fatorial(10));
/*

Console.WriteLine("Digite a quantidade de elementos que deseja cadastrar(min 5): ");

int Qtde = int.Parse(Console.ReadLine());
int controle = 0;
if (Qtde > 4)
{
    int[] vetor = new int[Qtde];

    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Digite os elementos que serão inseridos no vetor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();

    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
    Console.WriteLine("================================");

    //       *
    //{ 5; 4; 3; 2; 1 }

    for (int i = 0; i < vetor.Length; i++)
    {
        for(int j = i + 1; j < vetor.Length; j++)
        {
            if (vetor[i] > vetor[j])
            {
                controle = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = controle;
            }
        }
        Console.WriteLine(vetor[i]);

    }
}
else
{
    Console.WriteLine("Tamanho mínimo exigido: 5");
}
*/

int fatorial(int n)
{
    /*
    int x = 1;

    for (int i = n; i > 1; i--)
    {
        x *= i;
    }
    return x;
    */
    
    if (n > 1)
        return n * fatorial(n - 1);
    else
        return n;  
}










