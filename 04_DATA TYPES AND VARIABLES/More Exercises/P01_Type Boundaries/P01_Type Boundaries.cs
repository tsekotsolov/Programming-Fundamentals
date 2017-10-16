using System;


namespace P01_Type_Boundaries
{
    class Program
    {
        static void Main()
        {
            string numType = Console.ReadLine();

            if (numType == "int")
            {
                Console.WriteLine($"{int.MaxValue}{Environment.NewLine}{int.MinValue}");
            }
            else if (numType == "long")
            {
                Console.WriteLine($"{long.MaxValue}{Environment.NewLine}{long.MinValue}");
            }
            else if (numType == "uint")
            {
                Console.WriteLine($"{uint.MaxValue}{Environment.NewLine}{uint.MinValue}");
            }

            else if (numType == "byte")
            {
                Console.WriteLine($"{byte.MaxValue}{Environment.NewLine}{byte.MinValue}");
            }
            else if (numType == "sbyte")
            {
                Console.WriteLine($"{sbyte.MaxValue}{Environment.NewLine}{sbyte.MinValue}");
            }

        }
    }
}
