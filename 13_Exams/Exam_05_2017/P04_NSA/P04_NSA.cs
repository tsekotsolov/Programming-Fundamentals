using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                var input = inputLine.Split(new[] { " -> " }, StringSplitOptions.None).ToList();

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
                    spyRegister[countryName].RemoveRange(0, 1);
                }


                spyRegister[countryName].Add(spy);

                inputLine = Console.ReadLine();

            }

            var sortedSpyRegister = spyRegister.OrderByDescending(x => x.Value.Count);

            foreach (var country in sortedSpyRegister)
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
