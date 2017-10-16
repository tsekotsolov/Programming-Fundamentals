using System;


namespace P03_Megapixels
{
    class P03_Megapixels
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = Math.Round((width * height / 1000000.0),1);

            Console.WriteLine($"{width}x{height} => {result}MP");

        }
    }
}
