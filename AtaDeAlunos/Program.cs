using AtaDeAlunos;
using System.Globalization;
using System.Runtime.Serialization;

List<Aluno> Alunos = new List<Aluno>()
{
    new Aluno() { Nome = "aluno6", Notas = new int[] { 10, 9, 10 } },
    new Aluno() { Nome = "aluno7", Notas = new int[] { 5, 6, 5 } },
    //new Aluno() { Nome = "aluno1", Notas = new int[] { 3, 4, 10, 4, 10, 10, 10, 1 } },
    new Aluno() { Nome = "aluno3", Notas = new int[] { 4, 3, 3 } },
    new Aluno() { Nome = "aluno5", Notas = new int[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno4", Notas = new int[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno2", Notas = new int[] { 3, 4, 10 } }
};

int media = 0;
int soma = 0;

List<double> Medias = new List<double>();


for(int i = 0; i <= Alunos.Count; i++)
{
    for (int j = 0; j <= Alunos[i].Notas[j]; j++)
    {
        media = (media + Alunos[i].Notas[j]) / 3;
    }

    Medias.Add(media);
}



//media = (Alunos[0].Notas[0] + Alunos[0].Notas[1] + Alunos[0].Notas[2]) / 3;
//Console.WriteLine(media);




Console.WriteLine(Alunos[0].Nome + " " +  media);
Console.WriteLine(Alunos[1].Nome);
Console.WriteLine(Alunos[2].Nome);
Console.WriteLine(Alunos[3].Nome);
Console.WriteLine(Alunos[4].Nome);
Console.WriteLine(Alunos[5].Nome);
Console.WriteLine(Alunos[6].Nome);