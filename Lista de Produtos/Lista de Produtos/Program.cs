using System;
using System.Collections.Generic;
using System.Linq;

namespace listadecompras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ProdutosDisponiveis = new List<string>()                //criando lista dos produtos
            {
                "pão", "leite", "carne", "ovo", "fermento", "arroz", "refrigerante"
            };

            //validar se os argumentos foram preenchidos
            try
            {
                //listar quais produtos do argumento informado tem na lista do mercado
                var produtosselecionados = ProdutosDisponiveis.Where(produto => args.Contains(produto)).ToList();        //checa se os produtos estão na lista de argumentos
                foreach(var produtosselecionado in produtosselecionados)
                {
                    Console.WriteLine($"Esse produto nós temos: {produtosselecionado}");
                }

                //listar quais produtos do argumento informado NÃO tem na lista do mercado
                var ProdutosNaoDisponiveis = args.Where(args => !ProdutosDisponiveis.Contains(args)).ToList();         //aqui checa quais produtos não tem
                foreach(var ProdutosNaoDisponivel in ProdutosNaoDisponiveis)
                {
                    Console.WriteLine($"Esse produtos não temos infelizmente: {ProdutosNaoDisponivel}");
                }

                //retorna os produtos que tem na lista do mercado em ordem alfabética
                var produtodisponivelordenadopornome = ProdutosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtoordenado in produtodisponivelordenadopornome)             
                {
                    Console.WriteLine($"Estes são os produtos disponíveis: {produtoordenado}");
                }

            }
               
            catch (Exception)
            {
                Console.WriteLine("Argumento inválido");
            }
            
          


        }
    }


}
