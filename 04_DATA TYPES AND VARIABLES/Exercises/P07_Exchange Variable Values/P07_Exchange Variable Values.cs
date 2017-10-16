using System;

namespace P07_Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstVariable}");
            Console.WriteLine($"b = {secondVariable}");

            
            int helper = firstVariable;
            firstVariable = secondVariable;
            secondVariable = helper;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstVariable}");
            Console.WriteLine($"b = {secondVariable}");
        }
    }
}
