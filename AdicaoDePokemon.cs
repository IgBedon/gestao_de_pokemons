namespace AreaDeTestes
{
    public class AdicaoDePokemons
    {
        public static void AdicionarPokemon(List<Pokemon> listaPokedex)
        {
            ListagemDePokemons.ListarPokedex(listaPokedex);
            List<Pokemon> listaPokedexAtualizada = InteracaoUsuario.AdicionarPokemonsPokedex(listaPokedex);
            Salvar.SalvarPokedex(listaPokedexAtualizada);
            ListagemDePokemons.ListarPokedex(listaPokedexAtualizada);
        }

        public static void AdicionarPokemon(List<Pokemon> listaPokedex, List<Pokemon> listaEquipe, string nomeTreinador)
        {
            ListagemDePokemons.ListarEquipe(listaPokedex);
            List<Pokemon> listaEquipeAtualizada = InteracaoUsuario.AdicionarPokemonsEquipe(listaEquipe, listaPokedex);
            Salvar.SalvarEquipe(listaEquipeAtualizada, nomeTreinador);
            ListagemDePokemons.ListarEquipe(listaEquipeAtualizada);

        }
    }
}