using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class P01_AnonymousDownsite
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0M;

            List<string> affectedSites = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                var siteName = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal sitePricePerVisit = decimal.Parse(input[2]);

                totalLoss += siteVisits * sitePricePerVisit;

                affectedSites.Add(siteName);
            }

            for (int i = 0; i < affectedSites.Count; i++)
            {
                Console.WriteLine(affectedSites[i]);
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");

            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), n)}");

        }
    }
}
