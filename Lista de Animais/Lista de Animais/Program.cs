using Lista_de_Animais.Classes_de_animais;
using System;
using System.Collections.Generic;

namespace ListaDeAnimais
{
    class Program
    {
        /*   Escrever um programa 
             Recebe um nome de animal vertebrado 
             de acordo com um filtro, 
             identifica a qual dos grupos ele pertence (Mamífero, Réptil, Ave e Peixe), 
             e exibir os dados genéricos e exclusivos de cada grupo de animal. 
        */

        static void Main(string[] args)
        {

            //aqui recebe o nome do animal
            Console.WriteLine("Insira o nome de um animal");
            var nomeodnaimal = Console.ReadLine();
            if(string.IsNullOrEmpty(nomeodnaimal) || string.IsNullOrWhiteSpace(nomeodnaimal)) //aqui checa
            {
                Console.WriteLine("Insira o nome de um animal vertebrado válido");
                return;
            }

            var listadeanimais = new List<Animal>();
            listadeanimais.Add(new Mamífero() { Nome = "Vaca", Quatidadedemamas = 4 });
            listadeanimais.Add(new Réptil() { Nome = "Jacaré"});
            listadeanimais.Add(new Ave() { Nome = "Gavião" });
            listadeanimais.Add(new Peixe() { Nome = "Tilápia", quatidadenadadeira = 3 });

            //filtro para encontrar o animal
            var AnimalSelecionado = listadeanimais.FirstOrDefault(Animal => Animal.Nome.ToUpper() == nomeodnaimal.ToUpper());

            //identifica qual grupo ele pertence
            if(AnimalSelecionado == null) //caso não esteja
            {
                Console.WriteLine("O animal selecionado não está na nossa lista");
                return;
            }

            if(AnimalSelecionado is Mamífero)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome: "+$"{AnimalSelecionado.Nome} com quatidade de mamas = {((Mamífero)AnimalSelecionado).Quatidadedemamas}");
            }else if(AnimalSelecionado is Réptil)
            {
                Console.WriteLine($"O animal encontrado é um réptil com nome: "+$"{AnimalSelecionado.Nome} e não sabe controlar sua temperatura = {((Réptil)AnimalSelecionado).Controlartemperatura}");
            }else if(AnimalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome: "+$"{AnimalSelecionado.Nome} e tem penas = {((Ave)AnimalSelecionado).Tempena}");
            }else if(AnimalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome: " +$"{AnimalSelecionado.Nome} e tem {((Peixe)AnimalSelecionado).quatidadenadadeira} nadadeiras");
            }
            else
            {
                Console.WriteLine($"O nome do animal encontrado é"+$"{AnimalSelecionado.Nome}");
            }
        }
    }
}