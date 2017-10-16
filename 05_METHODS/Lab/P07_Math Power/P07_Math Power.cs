using System;

namespace P07_Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, int power)
        {

           double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
