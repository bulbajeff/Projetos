
int numero = 0;
bool continua = true;


while (continua)
{
    Console.WriteLine("Digite o número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 1)
    {
        Console.WriteLine("O número deve ser maior do que zero");
        continua = false;
    }

    if(verificaPrimo(numero))
    {
        Console.WriteLine("É primo");
    }
    else
    {
        Console.WriteLine("Não é primo");
    }
}

static bool verificaPrimo(int numero)
{
    int contador = 0;

    for (int i = numero; i <= numero && i > 0; i--)
    {
        if (numero % i == 0)
        {
            contador++;                        
        }
    }

    if (contador > 2)
    {
        return false;
    }

    else
    {
        return true;
    }
}
