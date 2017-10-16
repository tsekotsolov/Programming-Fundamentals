using System;

namespace P16_Comparing_Floats
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool isEqual = (Math.Abs(firstNumber - secondNumber) < eps);
            
            if(!isEqual)
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
    }
}
