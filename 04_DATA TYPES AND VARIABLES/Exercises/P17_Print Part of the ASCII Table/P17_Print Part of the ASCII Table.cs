using System;


namespace P17_Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
