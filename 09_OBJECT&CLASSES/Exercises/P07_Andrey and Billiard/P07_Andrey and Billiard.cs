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
            public Dictionary<string, int> CustomerWishList { get; set; } = new Dictionary<string, int>();
            public decimal ClientBill { get; set; }

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
                    menu[inputLine[0]] = 0;
                }

                menu[inputLine[0]] = decimal.Parse(inputLine[1]);
            }




            var line = Console.ReadLine();

            var nameWishList = new Dictionary<string, Dictionary<string, int>>();
            var nameBill = new SortedDictionary<string, decimal>();
            var shopList = new Dictionary<string, int>();
            var totalBill = 0.0M;

            while (line != "end of clients")
            {

                var customersInput = line.Split('-', ',');


                Customer currentCustomer = new Customer();

                //currentCustomer = createCustomer(customersInput);

                currentCustomer.Name = customersInput[0];
                currentCustomer.CustomerWishList[customersInput[1]] = int.Parse(customersInput[2]); 

                if (!nameWishList.ContainsKey(currentCustomer.Name) && currentCustomer.CustomerWishList.ContainsKey(customersInput[1]) == menu.ContainsKey(customersInput[1]))
                {
                    nameWishList[currentCustomer.Name] = currentCustomer.CustomerWishList;

                }
                if (nameWishList.ContainsKey(currentCustomer.Name))
                {
                    foreach (var name in nameWishList)
                    {
                        foreach (var productqtyPair in name.Value)
                        {
                            if (productqtyPair.Key.Contains(customersInput[1]))
                            {
                                productqtyPair.Value += int.Parse(customersInput[2]);
                            }
                        }
                    }
                }

                if (!nameBill.ContainsKey(currentCustomer.Name) && nameWishList.ContainsKey(currentCustomer.Name))
                {

                    currentCustomer.ClientBill = int.Parse(customersInput[2]) * menu[customersInput[1]];

                    nameBill[currentCustomer.Name] = currentCustomer.ClientBill;

                    shopList[customersInput[1]] = int.Parse(customersInput[2]);
                }


                totalBill += currentCustomer.ClientBill;

                line = Console.ReadLine();
            }




            foreach (var client in nameBill)
            {
                Console.WriteLine(client.Key);

                foreach (var item in nameWishList)
                {
                    if (client.Key == item.Key)
                    {
                        Console.Write($"-- {string.Join(" ", item.Value.Keys)} -");
                        Console.WriteLine($" {string.Join(" ", item.Value.Values)}");
                    }



                }

                Console.WriteLine($"Bill: {client.Value:f2}");

            }


            Console.WriteLine($"Total bill: {totalBill:f2}");

        }

        //private static Customer createCustomer(string[] customers)
        //{
        //    Customer customer = new Customer();
        //    customer.Name = customers[0];
        //    customer.CustomerWishList[customers[1]] = int.Parse(customers[2]);
        //    return customer;
        //}
    }
}
