﻿using System;
using Newtonsoft.Json;

namespace AreaDeTestes
{
    class Program
    {
        enum OpcaoPokedex {Adicionar=1, Remover, Listar, Sair}
        enum OpcaoEquipe {Adicionar=1, Remover, Listar, Sair}
        static void Main(string[] args)
        {   
            var ListaInicialPokedex = Carregamento.CarregarPokedex() ?? new List<Pokemon>();

            var treinador = new Treinador();
            Console.WriteLine("Qual é o seu nome, Treinador?");
            treinador.nome = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo, {treinador.nome}");

            var ListaInicialEquipe = Carregamento.CarregarEquipe(treinador.nome) ?? new List<Pokemon>();
                
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
                        case OpcaoPokedex.Adicionar: AdicaoDePokemons.AdicionarPokemonPokedex(ListaInicialPokedex); 
                            break;
                        case OpcaoPokedex.Remover: RemocaoDePokemon.RemoverPokemon(ListaInicialPokedex);
                            break;
                        case OpcaoPokedex.Listar: ListagemDePokemons.ListarPokedex();
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
                        case OpcaoEquipe.Adicionar: AdicaoDePokemons.AdicionarPokemonEquipe(ListaInicialPokedex, ListaInicialEquipe, treinador.nome); 
                            break;
                        case OpcaoEquipe.Remover: RemocaoDePokemon.RemoverPokemon(ListaInicialEquipe, treinador.nome);
                            break;
                        case OpcaoEquipe.Listar: ListagemDePokemons.ListarEquipeTreinador(ListaInicialEquipe);
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