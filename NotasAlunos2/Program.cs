// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//faça um algoritmo que mostre qual é o maior valor entre as 4 variáveis.

int a = 70; int b = 60; int c = 40; int d = 50;

int controle = 0;

if (a > b)
    controle = a;
else
    controle = b;

if (controle > c)
{
    if (controle < d)
    {
        controle = d;
    }
}
else
if (c > d)
{
    controle = c;
}
else 
    controle = d;

Console.WriteLine(controle);


