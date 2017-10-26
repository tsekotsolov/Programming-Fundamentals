using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; } = new Dictionary<string, int>();
            public decimal Bill { get; set; }
        }

        static void Main()
        {
            var menu = new Dictionary<string, decimal>();
            int productsInMenu = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsInMenu; i++)
            {
                var productsInput = Console.ReadLine().Split('-');

                var product = productsInput.First();
                var productPrice = productsInput
                    .Skip(1)
                    .Select(decimal.Parse);

                if (!menu.ContainsKey(product))
                {
                    menu.Add(product, 0.0M);
                }
                menu[product] = productPrice.First();
            }

            SortedDictionary<string, Customer> customerDataBase = new SortedDictionary<string, Customer>();

            var input = Console.ReadLine();
            var totalBill = 0.0M;
            while (input != "end of clients")
            {
                var inputLine = input.Split('-', ',');
                var name = inputLine.First();
                var product = inputLine[1];
                var qty = inputLine.Skip(2).Take(1).Select(int.Parse).First();

                Dictionary<string, int> shopList = new Dictionary<string, int>();


                if (menu.ContainsKey(product))
                {
                    var bill = qty * menu[product];

                    Customer customer = new Customer()
                    {
                        Name = name,
                        ShopList = shopList,
                        Bill = bill
                    };

                    if (!customerDataBase.ContainsKey(name))
                    {
                        shopList.Add(product, qty);
                        customerDataBase.Add(name, customer);

                    }

                    else if (customerDataBase[name].ShopList.ContainsKey(product))
                    {
                        customerDataBase[name].ShopList[product] += qty;
                        customerDataBase[name].Bill += bill;
                    }

                    else
                    {

                        customerDataBase[name].ShopList.Add(product, qty);
                        customerDataBase[name].Bill += bill;
                    }
                    totalBill += bill;
                }

                input = Console.ReadLine();
            }

            foreach (var client in customerDataBase)
            {
                Console.WriteLine(client.Key);

                foreach (var item in client.Value.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value} ");
                }

                Console.WriteLine($"Bill: {client.Value.Bill:f2}");

            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

    }
}
