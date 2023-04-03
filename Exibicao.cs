namespace AreaDeTestes
{
    public class Exibicao
    {
        Pokemon pokemon = new Pokemon();
        public void ImprimirInformacoesPokemon(Pokemon pokemon)
        {
            Console.WriteLine($"Nome: {pokemon.Nome}");
            Console.WriteLine($"Tipo: {pokemon.Tipo}");
            Console.WriteLine($"Nível: {pokemon.Nivel}");
            Console.WriteLine($"Pontos de vida: {pokemon.Vida}");
            Console.WriteLine($"Pontos de experiência: {pokemon.Experiencia}\n");
        }
    }
}