using System;

namespace EstruturadeRepetição
{
    class Program
    {
        static void Main(string[] args)          //informei 6 argumento
        {
            if(args.Length == 0)       //aqui conferiu se os argumentos era igual a 0
            {
                Console.WriteLine("favor informar palavras no argumento");    //como tinha 6 então era falso, então não entrou aqui
                return;
            }

            // 1° FOR
            for (var i = 0; i < args.Length; i++) // for só existe com 3 clasulas (variável de controle, condição e incremento da var de controle)
            {
                Console.WriteLine($"Estrutura for, índice e valor: {i}, {args[i]}");    // $ pra poder colocar a variável
            }

            // While
            var argslidos = 0;
            while (argslidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, args e valor lido: {argslidos}, {args[argslidos]}"); //condição checada antes de executar
                argslidos++;
            }

            // do while
            var loopsefetuado = 0;
            do                                        // primeiro executa e depois checa
            {
                Console.WriteLine($"estrutura do while, loops efetuados: {loopsefetuado}, e valor lido: {args[loopsefetuado]} ");   
                loopsefetuado++;
            } while (loopsefetuado < args.Length);

            //foreach (ele sempre percorre o tamanho de uma lista)
            foreach(var argumento in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido: {args}"); //ele sempre parte uma de lista
            }


        }
    }
}