namespace AreaDeTestes
{
    public class RemocaoDePokemon
    {
        public static void RemoverPokemon(List<Pokemon> listaPokedex)
        {
            ListagemDePokemons.ListarPokedex();
            List<Pokemon> listaPokedexAtualizada = InteracaoUsuario.InserirIndiceRemocaoPokedex(listaPokedex);
            List<Pokemon> pokedexAtualizada = Pokedex.AtualizarPokedex(listaPokedexAtualizada); 
            Salvar.SalvarPokedex(pokedexAtualizada);
        }

        public static void RemoverPokemon(List<Pokemon> listaEquipe, string nomeTreinador)
        {
            ListagemDePokemons.ListarEquipeTreinador(listaEquipe);
            List<Pokemon> listaEquipeAtualizada = InteracaoUsuario.InserirIndiceRemocaoEquipe(listaEquipe);
            Salvar.SalvarEquipe(listaEquipeAtualizada, nomeTreinador);
        }
    }
}