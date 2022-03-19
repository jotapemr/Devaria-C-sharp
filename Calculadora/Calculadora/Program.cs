using System;

namespace Calculadora 
{
    class Program
    {
        static float RealizarOperacao(float primeironumero, float segundonumero, string operador)
        {
            switch (operador)
            {
                case "+": return primeironumero + segundonumero;
                case "-": return primeironumero - segundonumero;
                case "*": return primeironumero * segundonumero;
                case "/": return primeironumero / segundonumero;
                case "%": return primeironumero % segundonumero;
                default: return 0f;
            }
               
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var primeironumeroString = Console.ReadLine();      //captura do número
            float primeironumero;

            bool isprimeironumerovalido = float.TryParse(primeironumeroString, out primeironumero);
                if (!isprimeironumerovalido)   // se ele não for válido
                {
                Console.WriteLine("Primeiro número inválido");
                return;
                }

            Console.WriteLine("Informe os segundo número: ");
            var segundonumeroString = Console.ReadLine();      //captura do segundo número
            float segundonumero;

            bool issegundonumerovalido = float.TryParse(segundonumeroString, out segundonumero);
                if (!issegundonumerovalido)   // se ele não for válido
                {
                Console.WriteLine("Segundo número inválido");
                return;
                }
            Console.WriteLine("Informe o operador matemático: ");
            var operador = Console.ReadLine();
            float resultado = RealizarOperacao(primeironumero, segundonumero, operador);
            Console.WriteLine("O resultado da sua informação foi: " + resultado);           //final
        }

    }






}
