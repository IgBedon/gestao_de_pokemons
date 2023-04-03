namespace AreaDeTestes
{
    public class Treinador
    {
        public string nome;
        private static List<Pokemon> listaDePokemonsEquipe;

        public static List<Pokemon> AdicionarPokemonEquipe(List<Pokemon> pokedex, int indicePokemon)
        {   
            listaDePokemonsEquipe.Add(pokedex[indicePokemon]);
            return listaDePokemonsEquipe;
        }

        public static List<Pokemon> RemoverPokemonEquipe(int indicePokemon)
        {
            listaDePokemonsEquipe.RemoveAt(indicePokemon);
            return listaDePokemonsEquipe;
        }

        public static List<Pokemon> ListarEquipe(List<Pokemon> listaInicialEquipe)
        {
            listaDePokemonsEquipe = listaInicialEquipe;
            return listaDePokemonsEquipe;
        }
        
    }
}