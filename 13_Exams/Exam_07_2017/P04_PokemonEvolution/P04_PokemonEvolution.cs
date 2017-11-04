using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_PokemonEvolution
{
    class P04_PokemonEvolution
    {
        class Pokemon
        {
            public string Name { get; set; }
            public List<string> EvoType { get; set; } = new List<string>();
            public List<int> EvoIndex { get; set; } = new List<int>();

        }

        static void Main()
        {

            var inputLine = Console.ReadLine();

            Dictionary<string, Pokemon> database = new Dictionary<string, Pokemon>();



            while (inputLine != "wubbalubbadubdub")
            {

                var input = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var pokemonName = input.First();

                if (input.Count == 1 && database.ContainsKey(pokemonName))
                {
                    Console.WriteLine($"# {pokemonName}");

                    for (int i = 0; i < database[pokemonName].EvoType.Count; i++)
                    {
                        Console.WriteLine($"{database[pokemonName].EvoType[i]} <-> {database[pokemonName].EvoIndex[i]}");
                    }

                    inputLine = Console.ReadLine();
                    continue;

                }


                var evoType = input.Skip(1).First();
                var evoIndex = input.Skip(2).Select(int.Parse).First();


                List<string> EvoType = new List<string>();
                List<int> EvoIndex = new List<int>();

                EvoType.Add(evoType);
                EvoIndex.Add(evoIndex);

                Pokemon pokemon = new Pokemon
                {
                    Name = pokemonName,
                    EvoType = EvoType,
                    EvoIndex = EvoIndex
                };



                if (!database.ContainsKey(pokemonName))
                {
                    database.Add(pokemonName, pokemon);
                }

                else
                {
                    database[pokemonName].EvoIndex.Add(evoIndex);
                    database[pokemonName].EvoType.Add(evoType);
                }

                inputLine = Console.ReadLine();
            }

            database.OrderByDescending(x => x.Value.EvoIndex.OrderByDescending(z => z));

            foreach (var pokemon in database)
            {
                Console.WriteLine($"# {pokemon.Key}");

                for (int i = 0; i < pokemon.Value.EvoType.Count; i++)
                {
                    Console.WriteLine($"{pokemon.Value.EvoType[i]} <-> {pokemon.Value.EvoIndex[i]}");
                }

            }
        }
    }
}
