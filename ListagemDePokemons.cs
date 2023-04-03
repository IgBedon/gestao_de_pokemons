namespace AreaDeTestes
{
    public class ListagemDePokemons
    {
        public static void ListarPokedex()
        {
            Exibicao InfoPokemon = new Exibicao();
            List<Pokemon> listaPokedex = Pokedex.ListarPokedex();
            if(listaPokedex.Count == 0)
            {
                Console.WriteLine("A Pokedex está vazia!");
            }
            else
            {
                int id=0;
                Console.WriteLine("\nLista de Pokemons da Pokedex:");
                foreach(Pokemon pokemon in listaPokedex)
                {
                    Console.WriteLine(id);
                    InfoPokemon.ImprimirInformacoesPokemon(pokemon);
                    id++;
                }
            }
        }

        public static void ListarEquipeTreinador(List<Pokemon> listaInicialEquipe)
        {
            Exibicao InfoPokemon = new Exibicao();
            List<Pokemon> listaEquipe = Treinador.ListarEquipe(listaInicialEquipe);
            if(listaEquipe.Count == 0)
            {
                Console.WriteLine("Equipe está vazia!");
            }
            else
            {
                int id=0;
                Console.WriteLine("\nLista de Pokemons na equipe:");
                foreach(Pokemon pokemonEquipe in listaEquipe)
                {
                    Console.WriteLine(id);
                    InfoPokemon.ImprimirInformacoesPokemon(pokemonEquipe);
                    id++;
                }
            }
        }
    }
}