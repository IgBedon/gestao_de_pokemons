namespace AreaDeTestes
{
    public class Pokedex
    {
        private static List<Pokemon> pokedex = Carregamento.CarregarPokedex() ?? new List<Pokemon>();
        
        public static List<Pokemon> AtualizarPokedex(List<Pokemon> listaPokedexAtualizada)
        {   
            pokedex = listaPokedexAtualizada;
            return pokedex;
        }

        public static List<Pokemon> ListarPokedex()
        {
            return pokedex;
        }
    }
}