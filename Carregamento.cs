using Newtonsoft.Json;

namespace AreaDeTestes
{
    public class Carregamento
    {
        public static List<Pokemon>? CarregarPokedex()
        {
            using(FileStream stream = new FileStream("Pokedex.json", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(stream))
                {
                    try
                    {
                        string conteudo = sr.ReadToEnd();

                        if (conteudo == null)
                        {
                            List<Pokemon> ListaDePokemon = new List<Pokemon>();
                            return ListaDePokemon;
                        }
                        else
                        {
                            List<Pokemon> ListaDePokemon = JsonConvert.DeserializeObject<List<Pokemon>>(conteudo);
                            return ListaDePokemon;
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro ao carregar Pokedex: {e.Message}");
                        return null;
                    }
                }
            }
        }

        public static List<Pokemon>? CarregarEquipe(string nomeTreinador)
        {
            using(FileStream stream = new FileStream("EquipePokemon" + nomeTreinador + ".json", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(stream))
                {
                    try
                    {
                        string conteudo = sr.ReadToEnd();

                        if (conteudo == null)
                        {
                            List<Pokemon> ListaDePokemonsEquipe = new List<Pokemon>();
                            return ListaDePokemonsEquipe;
                        }
                        else
                        {
                            List<Pokemon> ListaDePokemonsEquipe = JsonConvert.DeserializeObject<List<Pokemon>>(conteudo);
                            return ListaDePokemonsEquipe;
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro ao carregar Equipe: {e.Message}");
                        return null;
                    }
                }
            }
        }
    }
}