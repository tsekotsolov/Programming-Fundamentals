using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }

            public Dictionary<string, int> ProductQuantityDict = new Dictionary<string, int>();
            public decimal TotalPrice { get; set; }
            //public string DesiredProduct { get; set; }
            //public int Quantity { get; set; }

        }
        static void Main()
        {
            int numberofInputs = int.Parse(Console.ReadLine());

            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < numberofInputs; i++)
            {
                var inputLine = Console.ReadLine().Split('-');

                if (!menu.ContainsKey(inputLine[0]))
                {
                    menu[inputLine[0]] = decimal.Parse(inputLine[1]);
                }

                menu[inputLine[0]] = decimal.Parse(inputLine[1]);
            }

           

            while (true)
            {
                var customersInput = Console.ReadLine().Split('-',',');

                Customer currentCustomer = new Customer();

                currentCustomer = createCustomer(customersInput);

            }
        }

        private static Customer createCustomer(string[] customers)
        {
            Customer customer = new Customer();

            customer.Name = customers[0];
            customer.ProductQuantityDict[customers[1]] = int.Parse(customers[2]);
            return customer; 
        }
    }
}
