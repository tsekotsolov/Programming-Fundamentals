using System;

namespace P02_VaporStore
{
    class P02_VaporStore
    {
        static void Main()
        {
            double intialCash = double.Parse(Console.ReadLine());

            double cash = intialCash;


            while (cash > 0)
            {
                
                string gameName = Console.ReadLine();

                if (cash == 0)
                {
                    break;
                }

                if (gameName == "OutFall 4")
                {

                    if (cash >= 39.99)
                    {
                        cash -= 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "CS: OG")
                {
                    if (cash >= 15.99)
                    {
                        cash -= 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (gameName == "Zplinter Zell")
                {
                    if (cash >= 19.99)
                    {
                        cash -= 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "Honored 2")
                {

                    if (cash >= 59.99)
                    {
                        cash -= 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "RoverWatch")
                {
                    if (cash >= 29.99)
                    {
                        cash -= 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "RoverWatch Origins Edition")
                {

                    if (cash >= 39.99)
                    {
                        cash -= 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (gameName == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${(intialCash - cash):f2}. Remaining: ${cash:f2}");
                    return;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

            }

            Console.WriteLine("Out of money!");

        }
    }
}
