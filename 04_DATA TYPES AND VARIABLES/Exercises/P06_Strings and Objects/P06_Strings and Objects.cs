using System;

namespace P06_Strings_and_Objects
{
    class Program
    {
        static void Main()
        {
            string wordFirst = Console.ReadLine();
            string wordSecond = Console.ReadLine();

            object sentance = wordFirst + " " + wordSecond;

            string concatenate = (string)sentance; 

            Console.WriteLine(concatenate);
        }
    }
}
