using Lista_de_Produtos__CLASSES_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaProdutosClasses
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            /*
                                                                      EXERCÍCIO
             Escrever um programa - OK 
            que recebe alguns produtos como argumento - OK 
            e validar se esse produtos estão na lista de itens disponíveis do mercado. - OK
            Caso estejam, avisar o usuário quais produtos estão disponíveis - OK
            e quais não estão e - OK
            exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, 
            para que o usuário possa pedir na próxima vez. - OK                         
            */

            List<Produto> ProdutosDisponiveis = new List<Produto>();
            ProdutosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Leite", Preco = 4.00 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Ovos", Preco = 6.05 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Castanha", Preco = 35.06 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Suco", Preco = 5.00 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Biscoito", Preco = 3.56 });    //seria a mesma coisa q um banco de dados
            ProdutosDisponiveis.Add(new Produto() { Nome = "Revista", Preco = 10.23 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Bala", Preco = 0.12 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Chocolate", Preco = 7.69 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.99 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Arroz", Preco = 35.00 });
            ProdutosDisponiveis.Add(new Produto() { Nome = "Feijão", Preco = 16.67 });

            //se não digitar nada aqui mostra que deve ser digitado
            if (argumentos.Length == 0)
            {
                Console.WriteLine("Você não mostrou os produtos que quer comprar");
                return;
            }
            //compara o nome do produto com o argumento (TouUpper é para não dar diferença em minúsculo e maiúsculo) 
            var produtosSelecionadosDisponiveis = ProdutosDisponiveis.Where(produto => argumentos.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));

            // Caso estejam, avisar o usuário quais produtos estão disponíveis 
            foreach (var produt in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produt.ExibirDadosProduto()}");
            }
            //aqui mostra os não disponíveis
            var produtosSelecionadosNAODisponiveis = argumentos.Where(argumento => !ProdutosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach (var ProdutoNAODisponivel in produtosSelecionadosNAODisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos infelizmente: {ProdutoNAODisponivel}");
            }
            //aqui vai as lista com todos os produtos disponíveis
            var produtosordenadospornome = ProdutosDisponiveis.OrderBy(produto => produto.Nome).ToList();
            
            foreach (var produtoordenado in produtosordenadospornome)
            {
                Console.WriteLine(produtoordenado.ExibirDadosProduto());
            }
        }

    }
}
