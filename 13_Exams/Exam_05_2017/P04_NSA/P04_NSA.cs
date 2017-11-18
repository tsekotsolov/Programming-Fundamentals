using System;
using System.Collections.Generic;
using System.Linq;


namespace P04_NSA
{
    class P04_NSA
    {
        class Spy
        {
            public string SpyName { get; set; }
            public long DaysInService { get; set; }
        }
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var spyRegister = new Dictionary<string, List<Spy>>();


            while (inputLine != "quit")
            {

                var input = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var countryName = input[0];
                var spyName = input[1];
                var daysInService = long.Parse(input[2]);


                Spy spy = new Spy()
                {
                    SpyName = spyName,
                    DaysInService = daysInService
                };

                if (!spyRegister.ContainsKey(countryName))
                {
                    spyRegister[countryName] = new List<Spy>();
                }

                else if (spyRegister[countryName].Any(x => x.SpyName.Contains(spyName)))
                {

                    int index = -1;
                    foreach (var spyPerson in spyRegister[countryName])
                    {
                        index++;
                        if (spyPerson.SpyName == spyName)
                        {
                            spyRegister[countryName].RemoveAt(index);
                            break;
                        }
                    }
                }

                spyRegister[countryName].Add(spy);

                inputLine = Console.ReadLine();

            }

            PrintResult(spyRegister);
        }

        private static void PrintResult(Dictionary<string, List<Spy>> spyRegister)
        {
            foreach (var country in spyRegister.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spy in country.Value.OrderByDescending(x => x.DaysInService))
                {
                    Console.WriteLine($"**{spy.SpyName} : {spy.DaysInService}");
                }
            }
        }
    }
}
