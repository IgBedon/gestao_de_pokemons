namespace AreaDeTestes
{
    public class Treinador
    {
        public string nome;
        public List<Pokemon> ListaDePokemonsEquipe = new List<Pokemon>();

        public void AdicionarPokemons(List<Pokemon> listaPokedex, List<Pokemon> listaEquipe, string nomeTreinador)
        {   
            AdicaoDePokemons.AdicionarPokemon(listaPokedex, listaEquipe, nomeTreinador);
        }

        public void RemoverPokemonsEquipe(List<Pokemon> listaEquipe, string nomeTreinador)
        {
            RemocaoDePokemon.RemoverPokemon(listaEquipe, nomeTreinador);
        }

        public void ListarEquipe(List<Pokemon> listaEquipe)
        {
            ListagemDePokemons.ListarEquipe(listaEquipe);
        }
        
    }
}