using System;

namespace P14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string hexa = Convert.ToString(number, 16);
            string binary = Convert.ToString(number, 2);

            Console.WriteLine($"{hexa.ToUpper()}{Environment.NewLine}{binary}");
            
        }
    }
}
