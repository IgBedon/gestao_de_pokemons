namespace AreaDeTestes
{
    public class InteracaoUsuario
    {
        public static List<Pokemon> AdicionarPokemonsPokedex(List<Pokemon> listaPokedex)
        {   
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
                listaPokedex.Add(novoPokemon);

                Console.WriteLine("Adição Realizada!");
                Console.WriteLine("=======================================");
            }
            return listaPokedex;
        }

        public static List<Pokemon> AdicionarPokemonsEquipe(List<Pokemon> listaEquipe, List<Pokemon> listaPokedex)
        {
            Console.WriteLine("Quantos pokemons deseja adicionar na sua equipe?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja adicionar:");
                int indicePokemon = int.Parse(Console.ReadLine());
                listaEquipe.Add(listaPokedex[indicePokemon]);

                Console.WriteLine("Adição Realizada!");
                Console.WriteLine("=======================================");
            }

            return listaEquipe;
        }

        public static List<Pokemon> RemoverPokemonsPokedex(List<Pokemon> listaPokedex)
        {
            Console.WriteLine("Quantos pokemons deseja remover?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja remover");
                listaPokedex.RemoveAt(int.Parse(Console.ReadLine())-i);
                
                Console.WriteLine("Remoção Concluída!");
                Console.WriteLine("=======================================");
            }
            return listaPokedex;
        }

        public static List<Pokemon> RemoverPokemonsEquipe(List<Pokemon> listaEquipe)
        {
            Console.WriteLine("Quantos pokemons deseja remover da sua equipe?");
            int[] quantidade = new int[int.Parse(Console.ReadLine())];
            for(int i=0; i<quantidade.Length; i++)
            {
                Console.WriteLine($"Insira o índice do {i+1}° Pokemon que deseja remover");
                listaEquipe.RemoveAt(int.Parse(Console.ReadLine())-i);
                
                Console.WriteLine("Remoção Concluída!");
                Console.WriteLine("=======================================");
            }
            return listaEquipe;
        }
    }
}