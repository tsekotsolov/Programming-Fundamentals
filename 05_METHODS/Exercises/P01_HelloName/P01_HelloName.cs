using System;


namespace P01_HelloName
{
    class P01_HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();

           PrintGreeting(name);
        }

         static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
