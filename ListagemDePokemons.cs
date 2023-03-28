namespace AreaDeTestes
{
    public class ListagemDePokemons
    {
        public static void ListarPokedex(List<Pokemon> listaPokedex)
        {
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
                    pokemon.ImprimirInformacoes();
                    id++;
                }
            }
        }

        public static void ListarEquipe(List<Pokemon> listaEquipe)
        {
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
                    pokemonEquipe.ImprimirInformacoes();
                    id++;
                }
            }
        }
    }
}