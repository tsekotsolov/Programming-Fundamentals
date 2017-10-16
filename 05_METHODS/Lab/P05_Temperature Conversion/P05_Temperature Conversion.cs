using System;

using System.Threading.Tasks;

namespace P05_Temperature_Conversion
{
    class Program
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            var celcius = ConvertFahrenheitToCelcius(fahrenheit);
            Console.WriteLine($"{celcius:f2}");
        }

        static double ConvertFahrenheitToCelcius(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }
}
