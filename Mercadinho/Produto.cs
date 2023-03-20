using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class Produto
    {
        public string Nome { get; set; }
        public double[] Preco { get; set; }

        public Produto()
        {
            this.Nome = string.Empty;
            this.Preco = new double[4];
        }

    }

    

}
