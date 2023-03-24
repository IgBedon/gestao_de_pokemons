using Newtonsoft.Json;

namespace AreaDeTestes
{
    public class Pokemon
    {   
        public string Nome {get ; set;}
        public string Tipo {get ; set;} 
        public int Nivel {get ; set;}  
        public int Vida {get ; set;}
        public double Experiencia {get ; set;}
        public static List<Pokemon> pokemons = new List<Pokemon>();

        public Pokemon(string nome, string tipo, int nivel, int vida, double experiencia)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Nivel = nivel;
            this.Vida = vida;
            this.Experiencia = experiencia;
        }

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Pontos de vida: {Vida}");
            Console.WriteLine($"Pontos de experiência: {Experiencia} \n");
        }

        public static void AdicionarPokemons(List<Pokemon> ListaDePokemons)
        {   
            if(ListaDePokemons != null)
            {
            ListarPokedex(ListaDePokemons);
            }
            Console.WriteLine("Quantos pokemons deseja adicionar?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o nome do {i+1}° Pokemon:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Insira o tipo do {i+1}° Pokemon:");
                string tipo = Console.ReadLine();
                Console.WriteLine($"Insira o nível do {i+1}° Pokemon:");
                int nivel = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira os pontos de vida do {i+1}° Pokemon:");
                int vida = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira os pontos de experiência do {i+1}° Pokemon:");
                double experiencia = Double.Parse(Console.ReadLine());
                Pokemon novoPokemon = new Pokemon(nome, tipo, nivel, vida, experiencia);
                ListaDePokemons.Add(novoPokemon);

                Console.WriteLine("Adição Realizada!");
                Console.WriteLine("=======================================");

                Salvar(ListaDePokemons);
            }
        }

        public static void RemoverPokemons(List<Pokemon> ListaDePokemons)
        {
            ListarPokedex(ListaDePokemons);
            Console.WriteLine("Quantos pokemons deseja remover?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja remover");
                ListaDePokemons.RemoveAt(int.Parse(Console.ReadLine())-i);
            }
            Console.WriteLine("Remoção Concluída!");
            Console.WriteLine("=======================================");
            Salvar(ListaDePokemons);
            ListarPokedex(ListaDePokemons);
        }

        public static void ListarPokedex(List<Pokemon> ListaDePokemons)
        {
            if(ListaDePokemons.Count == 0)
            {
                Console.WriteLine("A Pokedex está vazia!");
            }
            else
            {
                int id=0;
                Console.WriteLine("\nLista de Pokemons da Pokedex:");
                foreach(Pokemon pokemon in ListaDePokemons)
                {
                    Console.WriteLine(id);
                    pokemon.ImprimirInformacoes();
                    id++;
                }
            }
        }

        public static void Salvar(List<Pokemon> ListaDePokemons)
        {
            string jsonLista = JsonConvert.SerializeObject(ListaDePokemons);
            File.WriteAllText("Pokedex.json", jsonLista);
        }

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
    }
}