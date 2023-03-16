// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numeros = new[] { 4, 20, 13, 17 };

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > numeros[0])
    {
        numeros[0] = numeros[i];
    }
}

Console.WriteLine(numeros[0]);




//if (numeros[i] > numeros[i + 1])
//{
//    controle = numeros[i];
//}
//else
//    controle = numeros[i + 1];


//if (controle > c)
//{
//    if (controle < d)
//    {
//        controle = d;
//    }
//}
//else
//if (c > d)
//{
//    controle = c;
//}
//else
//    controle = d;

//Console.WriteLine(controle);