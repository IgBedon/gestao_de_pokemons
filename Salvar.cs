using Newtonsoft.Json;

namespace AreaDeTestes
{
    public class Salvar
    {
        
        public static void SalvarPokedex(List<Pokemon> ListaDePokemons)
        {
            string jsonLista = JsonConvert.SerializeObject(ListaDePokemons);
            File.WriteAllText("Pokedex.json", jsonLista);
        }
        
        public static void SalvarEquipe(List<Pokemon> equipePokemon, string nomeTreinador)
        {
            string jsonLista = JsonConvert.SerializeObject(equipePokemon);
            File.WriteAllText("EquipePokemon"+ nomeTreinador +".json", jsonLista);
        }
    }
}