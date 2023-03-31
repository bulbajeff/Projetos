using AtaDeAlunos;

List<Aluno> Alunos = new List<Aluno>()
{
    new Aluno() { Nome = "aluno6", Notas = new double[] { 10, 9, 10 } },
    new Aluno() { Nome = "aluno7", Notas = new double[] { 5, 6, 5 } },
    //new Aluno() { Nome = "aluno1", Notas = new int[] { 3, 4, 10, 4, 10, 10, 10, 1 } },
    new Aluno() { Nome = "aluno3", Notas = new double[] { 4, 3, 3 } },
    new Aluno() { Nome = "aluno5", Notas = new double[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno4", Notas = new double[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno2", Notas = new double[] { 3, 4, 10 } }
};

List<double> mediaSala = new List<double>();

double media = 0;
double soma = 0;

for(int i = 0; i < Alunos.Count; i++)
{
    soma = 0;
    media = 0;

    for (int j = 0; j < 3; j++)
    {
        soma = soma + Alunos[i].Notas[j];
    }

    media = soma / 3;

    mediaSala.Add(media);

    Console.WriteLine(Alunos[i].Nome + ": " + Math.Round(media, 2));
}

double somaMedia = 0;

foreach (double item in mediaSala)
{
    somaMedia = somaMedia + item;
}

somaMedia = somaMedia / 6;
Console.WriteLine("Média da sala: " + Math.Round(somaMedia, 2));
    
