namespace AreaDeTestes
{
    public class AdicaoDePokemons
    {
        public static void AdicionarPokemonPokedex(List<Pokemon> listaPokedex)
        {
            List<Pokemon> listaPokedexAtualizada = InteracaoUsuario.InserirDadosPokemonsPokedex(listaPokedex);
            List<Pokemon> pokedexAtualizada = Pokedex.AtualizarPokedex(listaPokedexAtualizada);
            Salvar.SalvarPokedex(pokedexAtualizada);
        }

        public static void AdicionarPokemonEquipe(List<Pokemon> listaPokedex, List<Pokemon> listaEquipe, string nomeTreinador)
        {
            ListagemDePokemons.ListarPokedex();
            List<Pokemon> equipeAtualizada = InteracaoUsuario.InserirIndiceAdicaoEquipe(listaEquipe, listaPokedex);
            Salvar.SalvarEquipe(equipeAtualizada, nomeTreinador);
        }
    }
}