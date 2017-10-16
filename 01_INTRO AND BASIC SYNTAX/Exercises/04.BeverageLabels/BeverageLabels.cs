using System;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());


            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume*0.01*energy}kcal, {volume*0.01*sugar}g sugars");


        }
    }
}
