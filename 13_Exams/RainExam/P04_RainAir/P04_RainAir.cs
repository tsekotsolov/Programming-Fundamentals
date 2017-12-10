using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_RainAir
{
    class P04_RainAir
    {
        class Customer
        {
            public List<long> Flights { get; set; }

        }

        static void Main()
        {
            var input = Console.ReadLine();

            var customersFlights = new Dictionary<string, Customer>();


            while (input != "I believe I can fly!")
            {
                var inputLine = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputLine[1] != "=")
                {
                    var customerName = inputLine[0];

                    var listOfFlights = new List<long>();

                    for (int i = 1; i < inputLine.Count; i++)
                    {
                        listOfFlights.Add(long.Parse(inputLine[i]));
                    }

                    Customer customer = new Customer();

                    customer.Flights = listOfFlights;

                    if (!customersFlights.ContainsKey(customerName))
                    {
                        customersFlights.Add(customerName, customer);
                    }

                    else
                    {
                        customersFlights[customerName].Flights.AddRange(listOfFlights);
                    }
                }

                else
                {
                    var firstCustomer = inputLine[0];
                    var secondCustomer = inputLine[2];


                    var ListofSecondCustomerFlights = new List<long>();

                    foreach (var item in customersFlights[secondCustomer].Flights)
                    {
                        ListofSecondCustomerFlights.Add(item);
                    }


                    customersFlights[firstCustomer].Flights.Clear();

                    customersFlights[firstCustomer].Flights = ListofSecondCustomerFlights;


                }

                input = Console.ReadLine();
            }

            foreach (var customer in customersFlights.OrderByDescending(x => x.Value.Flights.Count).ThenBy(x => x.Key))
            {
                Console.Write($"#{customer.Key} ::: ");


                Console.WriteLine(string.Join(", ", customer.Value.Flights.OrderBy(x => x)));

            }
        }
    }
}
