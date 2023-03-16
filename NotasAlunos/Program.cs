// See https://aka.ms/new-console-template for more information
using NotasAlunos;


// 1 - Cadastrar Alunos e Notas

List<Aluno> Alunos = new List<Aluno>()
{
    new Aluno() { Nome = "aluno6", Notas = new int[] { 10, 9, 10 } },
    new Aluno() { Nome = "aluno7", Notas = new int[] { 5, 6, 5 } },
    new Aluno() { Nome = "aluno1", Notas = new int[] { 3, 4, 10, 4, 10, 10, 10, 1 } },
    new Aluno() { Nome = "aluno3", Notas = new int[] { 4, 3, 3 } },
    new Aluno() { Nome = "aluno5", Notas = new int[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno4", Notas = new int[] { 3, 4, 10 } },
    new Aluno() { Nome = "aluno2", Notas = new int[] { 3, 4, 10 } }
};

List<double> Medias = new List<double>();

foreach (Aluno a in Alunos)
{
    for(int i = 0; Alunos[i] <= Alunos[i]; i++)
        
}



Console.ReadLine();

// 2 - Calcular a média individual

//for (int i = 0; i <= Alunos.Count; i++)
//{
//    for (int j = 0; i <= Alunos ; i++);
//}


// 3 - Calcular a média geral


// 4 - Nome e nota do melhor aluno







/*
NotaAluno aluno= new NotaAluno();

// 1 - Cadastrar Alunos e Notas
bool loop = true;

while(loop)
{
    Console.WriteLine("Digite o nome do aluno a ser cadastrado: ");
    aluno.NomeAluno = Console.ReadLine();
    Console.WriteLine("Digite quantas notas serão cadastradas para o aluno: ");
    int numeroNotas = int.Parse(Console.ReadLine());
    

    for (int i = 1; i <= numeroNotas; i++)
    {
        Console.WriteLine("Digite uma nota diferente de zero e tecle Enter: ");
        int notaX = int.Parse(Console.ReadLine());
        aluno.NotasAluno[i] = notaX;
    }

    Console.WriteLine("Deseja cadastrar mais algum? Responda 1 para SIM ou 2 para NÃO ");
    string resposta = Console.ReadLine();
    Console.WriteLine("A resposta foi " + resposta);
    
    if (resposta == "N")
    {
        loop = false;
    }

}



// 2 - Calcular a média individual

Console.WriteLine("======================================================");
Console.WriteLine("A média individual dos alunos cadastrados é:");

for(int i = 0; i < aluno.NomeAluno.Length; i ++)
{
    Console.WriteLine(aluno.NotasAluno[i] + ":" + aluno.NomeAluno[i]); 
}

Console.ReadLine();


// 3 - Calcular a média geral




// 4 - Nome e nota do melhor aluno
*/
