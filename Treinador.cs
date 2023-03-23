using Newtonsoft.Json;

namespace AreaDeTestes
{
    public class Treinador
    {
        public static string nomeTreinador;

        public void AdicionarPokemonsEquipe(List<Pokemon> ListaDePokemonsEquipe, List<Pokemon> ListaDePokemonsPokedex)
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

                Salvar(ListaDePokemonsEquipe);
                ListarEquipe(ListaDePokemonsEquipe);
            }
        }
        public void RemoverPokemonsEquipe(List<Pokemon> ListaDePokemonsEquipe)
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
            Salvar(ListaDePokemonsEquipe);
            ListarEquipe(ListaDePokemonsEquipe);
        }

        public static void Salvar(List<Pokemon> equipePokemon)
        {
            string jsonLista = JsonConvert.SerializeObject(equipePokemon);
            File.WriteAllText("EquipePokemon.json", jsonLista);
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
    }
}