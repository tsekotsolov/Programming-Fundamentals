using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_PokemonEvolution
{
    class P04_PokemonEvolution
    {
        class Pokemon
        {
           
            public string Type { get; set; }
            public int Index { get; set; }
        }

        static void Main()
        {

            var inputLine = Console.ReadLine();

            Dictionary<string, List<Pokemon>> database = new Dictionary<string, List<Pokemon>>();


            while (inputLine != "wubbalubbadubdub")
            {

                var input = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var pokemonName = input.First();


                if (input.Count > 1)
                {
                    var evoType = input.Skip(1).First();
                    var evoIndex = input.Skip(2).Select(int.Parse).First();

                    List<Pokemon> pokemonList = new List<Pokemon>();

                    Pokemon pokemon = new Pokemon
                    {
                        
                        Type = evoType,
                        Index = evoIndex
                    };

                    pokemonList.Add(pokemon);

                    if (!database.ContainsKey(pokemonName))
                    {
                        database.Add(pokemonName, pokemonList);
                    }

                    else
                    {
                        database[pokemonName].AddRange(pokemonList);
                    }

                    inputLine = Console.ReadLine();
                }

                else
                {

                    if (database.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");


                        foreach (var item in database[pokemonName])
                        {
                            Console.WriteLine($"{item.Type} <-> {item.Index}");
                        }
                    }
                  
                    inputLine = Console.ReadLine();
                    continue;

                }

            }

            foreach (var pokemon in database)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var item in pokemon.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{item.Type} <-> {item.Index}");
                }
            }
        }
    }
}
