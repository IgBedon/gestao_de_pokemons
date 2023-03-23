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
            List<Pokemon> ListaInicialPokedex = CarregarPokedex() ?? new List<Pokemon>();
            List<Pokemon> ListaInicialEquipe = CarregarEquipe() ?? new List<Pokemon>();


            Console.WriteLine("Qual é o seu nome, Treinador?");
            Treinador.nomeTreinador = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo, {Treinador.nomeTreinador}");
                
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
                    Treinador equipeDoTreinador = new Treinador();
                    switch(opcaoEscolhida)
                    {
                        case OpcaoEquipe.Adicionar: equipeDoTreinador.AdicionarPokemonsEquipe(ListaInicialEquipe, ListaInicialPokedex); 
                            break;
                        case OpcaoEquipe.Remover: equipeDoTreinador.RemoverPokemonsEquipe(ListaInicialEquipe);
                            break;
                        case OpcaoEquipe.Listar: equipeDoTreinador.ListarEquipe(ListaInicialEquipe);
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

        static List<Pokemon>? CarregarPokedex()
        {
            using(FileStream stream = new FileStream("Pokedex.json", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(stream))
                {
                    try
                    {
                        string conteudo = sr.ReadToEnd();

                        if (conteudo == null)
                        {
                            List<Pokemon> ListaDePokemon = new List<Pokemon>();
                            return ListaDePokemon;
                        }
                        else
                        {
                            List<Pokemon> ListaDePokemon = JsonConvert.DeserializeObject<List<Pokemon>>(conteudo);
                            return ListaDePokemon;
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro ao carregar Pokedex: {e.Message}");
                        return null;
                    }
                }
            }
        }

        static List<Pokemon>? CarregarEquipe()
        {
            using(FileStream stream = new FileStream("EquipePokemon.json", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(stream))
                {
                    try
                    {
                        string conteudo = sr.ReadToEnd();

                        if (conteudo == null)
                        {
                            List<Pokemon> ListaDePokemon = new List<Pokemon>();
                            return ListaDePokemon;
                        }
                        else
                        {
                            List<Pokemon> ListaDePokemon = JsonConvert.DeserializeObject<List<Pokemon>>(conteudo);
                            return ListaDePokemon;
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro ao carregar Equipe: {e.Message}");
                        return null;
                    }
                }
            }
        }

    }
}