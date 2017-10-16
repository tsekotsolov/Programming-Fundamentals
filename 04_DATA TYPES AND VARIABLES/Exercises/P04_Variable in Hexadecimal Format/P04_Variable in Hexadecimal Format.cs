using System;


namespace P04_Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(input,16));
        }
    }
}
