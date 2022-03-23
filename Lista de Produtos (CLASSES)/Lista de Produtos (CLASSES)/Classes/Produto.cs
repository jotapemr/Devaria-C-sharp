using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Produtos__CLASSES_.Classes
{
    internal class Produto
    { 

        public string Nome { get; set; } // get - permite que alguém do lado de fora acesse a informação
                                         // set - permite que alguem do lado de fora passe informação
        public double Preco { get; set; } //double é flutuante aceita número "quebrado"

        public string ExibirDadosProduto()
        {
            return $"Produto: {Nome} com valor de R$ {Preco}";

        } 
    }
}
