namespace AreaDeTestes
{
    public class Pokedex
    {
        public static void AdicionarPokemons(List<Pokemon> listaPokedex)
        {   
            AdicaoDePokemons.AdicionarPokemon(listaPokedex);
        }

        public static void RemoverPokemons(List<Pokemon> listaPokedex)
        {
            RemocaoDePokemon.RemoverPokemon(listaPokedex);
        }

        public static void ListarPokedex(List<Pokemon> listaPokedex)
        {
            ListagemDePokemons.ListarPokedex(listaPokedex);
        }
    }
}