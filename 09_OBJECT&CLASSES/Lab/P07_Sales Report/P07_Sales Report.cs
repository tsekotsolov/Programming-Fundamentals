using System;
using System.Collections.Generic;

namespace P07_Sales_Report
{
    class Program
    {

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

        }
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputLine =
                    Console.ReadLine()
                   .Split();

                Sale sale = new Sale();

                sale = ReadSale(inputLine);

                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var KeyValuePair in result)
            {
                Console.WriteLine($"{KeyValuePair.Key} -> {KeyValuePair.Value:f2}" );
            }

        }

        private static Sale ReadSale(string[] inputLine)
        {
            Sale currentSale = new Sale();
            currentSale.Town = inputLine[0];
            currentSale.Product = inputLine[1];
            currentSale.Price = decimal.Parse(inputLine[2]);
            currentSale.Quantity = decimal.Parse(inputLine[3]);

            return currentSale;
        }
    }
}
