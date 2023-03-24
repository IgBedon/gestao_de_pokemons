using Newtonsoft.Json;

namespace AreaDeTestes
{
    public class Treinador
    {
        public string nome;
        public List<Pokemon> ListaDePokemonsEquipe = new List<Pokemon>();

        public void AdicionarPokemonsEquipe(List<Pokemon> ListaDePokemonsEquipe, List<Pokemon> ListaDePokemonsPokedex, string nomeTreinador)
        {   
            if(ListaDePokemonsEquipe != null)
            {
                ListarEquipe(ListaDePokemonsEquipe);
                Pokemon.ListarPokedex(ListaDePokemonsPokedex);
            }

            Console.WriteLine("Quantos pokemons deseja adicionar na sua equipe?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja adicionar:");
                int indicePokemon = int.Parse(Console.ReadLine());
                ListaDePokemonsEquipe.Add(ListaDePokemonsPokedex[indicePokemon]);

                Console.WriteLine("Adição Realizada!");
                Console.WriteLine("=======================================");

                Salvar(ListaDePokemonsEquipe, nomeTreinador);
                ListarEquipe(ListaDePokemonsEquipe);
            }
        }
        public void RemoverPokemonsEquipe(List<Pokemon> ListaDePokemonsEquipe, string nomeTreinador)
        {
            ListarEquipe(ListaDePokemonsEquipe);
            Console.WriteLine("Quantos pokemons deseja remover da sua equipe?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja remover");
                ListaDePokemonsEquipe.RemoveAt(int.Parse(Console.ReadLine())-i);
            }
            Console.WriteLine("Remoção Concluída!");
            Console.WriteLine("=======================================");
            Salvar(ListaDePokemonsEquipe, nomeTreinador);
            ListarEquipe(ListaDePokemonsEquipe);
        }

        public void ListarEquipe(List<Pokemon> equipe)
        {
            if(equipe.Count == 0)
            {
                Console.WriteLine("Equipe está vazia!");
            }
            else
            {
                int id=0;
                Console.WriteLine("\nLista de Pokemons na equipe:");
                foreach(Pokemon pokemonEquipe in equipe)
                {
                    Console.WriteLine(id);
                    pokemonEquipe.ImprimirInformacoes();
                    id++;
                }
            }
        }

        public static void Salvar(List<Pokemon> equipePokemon, string nomeTreinador)
        {
            string jsonLista = JsonConvert.SerializeObject(equipePokemon);
            File.WriteAllText("EquipePokemon"+ nomeTreinador +".json", jsonLista);
        }

        public List<Pokemon>? CarregarEquipe(string nomeTreinador)
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
                            ListaDePokemonsEquipe = JsonConvert.DeserializeObject<List<Pokemon>>(conteudo);
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