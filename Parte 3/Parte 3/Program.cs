using System;

namespace ListaDeConvidade
{
    class Program
    {
        private static string[] ListaDeConvidados =
        {
            "Pedro", // 0
            "Matheus", // 1
            "João", // 2
            "Yasmim", // 3
            "Gabriel", // 4
            "Ale", // 5
            "Leitícia" // 6
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado: ");
            var nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado, insira uma informação válida: ");
                return;
            }
            Console.WriteLine("Informe a idade: ");
            var idadeString = Console.ReadLine();
            int idade;
            bool IdadeInformada = int.TryParse(idadeString, out idade);

            if (IdadeInformada == false)
            {
                Console.WriteLine("Idade não informada, insira uma informação válida");
                return;
            }
            bool EstáConvidado;
            switch (nome)
            {
                case "Pedro":
                    EstáConvidado = true;
                    break;
                case "Matheus":
                    EstáConvidado = true;
                    break;
                case "João":
                    EstáConvidado = true;
                    break;
                case "Yasmim":
                    EstáConvidado = true;
                    break;
                case "Gabriel":
                    EstáConvidado = true;
                    break;
                case "Ale":
                    EstáConvidado = true;
                    break;
                case "Leitícia":
                    EstáConvidado = true;
                    break;
                default:
                    EstáConvidado = false;
                    break;
            }

            if (EstáConvidado == true && idade >= 18)
            {
                Console.WriteLine("Parabéns seja bem vinda a festa");
            }
            else if (EstáConvidado == false)
            {
                Console.WriteLine("Sinto muito você não foi convidado");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }

        }
    }
}
    
        