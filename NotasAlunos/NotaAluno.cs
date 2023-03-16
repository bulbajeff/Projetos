using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlunos
{
    //public struct NotaAluno
    //{
    //    public string NomeAluno { get; set; }
    //    public int[] NotasAluno { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome:  {this.NomeAluno}" + 
    //               $"Nota: {this.NotasAluno}";
    //    }
    //}

    public class Aluno
    {
        public string Nome { get; set; }
        public int[] Notas { get; set; }
    }
}
