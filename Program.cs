using System;
using Newtonsoft.Json;

namespace AreaDeTestes
{
    class Program
    {
        enum OpcaoPokedex {Adicionar=1, Remover, Listar, Sair}
        enum OpcaoEquipe {Adicionar=1, Remover, Listar, Sair}
        static void Main(string[] args)
        {   
            var ListaInicialPokedex = Pokemon.CarregarPokedex() ?? new List<Pokemon>();

            var treinador = new Treinador();
            Console.WriteLine("Qual é o seu nome, Treinador?");
            treinador.nome = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo, {treinador.nome}");

            var ListaInicialEquipe = treinador.CarregarEquipe(treinador.nome) ?? new List<Pokemon>();
                
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                Console.WriteLine("Deseja mexer com a Pokedex [1], com a sua equipe [2] ou Sair [3]?");
                var primeiraEscolha = int.Parse(Console.ReadLine());
                if(primeiraEscolha == 1)
                {
                    Console.WriteLine("[1] Adicionar Pokemon na Pokedex \n[2] Remover Pokemon da Pokedex \n[3] Listar Pokemons da Pokedex \n[4] Sair");
                    OpcaoPokedex opcaoEscolhida = (OpcaoPokedex)int.Parse(Console.ReadLine());

                    switch(opcaoEscolhida)
                    {
                        case OpcaoPokedex.Adicionar: Pokemon.AdicionarPokemons(ListaInicialPokedex); 
                            break;
                        case OpcaoPokedex.Remover: Pokemon.RemoverPokemons(ListaInicialPokedex);
                            break;
                        case OpcaoPokedex.Listar: Pokemon.ListarPokedex(ListaInicialPokedex);
                            break;
                        case OpcaoPokedex.Sair: escolheuSair = true;
                            break;
                    }
                }
                else if(primeiraEscolha==2)
                {
                    Console.WriteLine("[1] Adicionar Pokemon na equipe \n[2] Remover Pokemon da equipe \n[3] Listar Pokemons da equipe \n[4] Sair");
                    OpcaoEquipe opcaoEscolhida = (OpcaoEquipe)int.Parse(Console.ReadLine());
                    switch(opcaoEscolhida)
                    {
                        case OpcaoEquipe.Adicionar: treinador.AdicionarPokemonsEquipe(ListaInicialEquipe, ListaInicialPokedex, treinador.nome); 
                            break;
                        case OpcaoEquipe.Remover: treinador.RemoverPokemonsEquipe(ListaInicialEquipe, treinador.nome);
                            break;
                        case OpcaoEquipe.Listar: treinador.ListarEquipe(ListaInicialEquipe);
                            break;
                        case OpcaoEquipe.Sair: escolheuSair = true;
                            break;
                    }
                }
                else if(primeiraEscolha==3)
                {
                    escolheuSair=true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Insira um valor válido na próxima vez!");
                }
            }

        }
    }
}