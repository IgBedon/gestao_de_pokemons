namespace AreaDeTestes
{
    public class RemocaoDePokemon
    {
        public static void RemoverPokemon(List<Pokemon> listaPokedex)
        {
            ListagemDePokemons.ListarPokedex(listaPokedex);
            List<Pokemon> listaPokedexAtualizada = InteracaoUsuario.RemoverPokemonsPokedex(listaPokedex);
            Salvar.SalvarPokedex(listaPokedexAtualizada);
            ListagemDePokemons.ListarPokedex(listaPokedexAtualizada);
        }

        public static void RemoverPokemon(List<Pokemon> listaEquipe, string nomeTreinador)
        {
            ListagemDePokemons.ListarEquipe(listaEquipe);
            List<Pokemon> listaEquipeAtualizada = InteracaoUsuario.RemoverPokemonsEquipe(listaEquipe);
            Salvar.SalvarEquipe(listaEquipeAtualizada, nomeTreinador);
            ListagemDePokemons.ListarEquipe(listaEquipeAtualizada);

        }
    }
}