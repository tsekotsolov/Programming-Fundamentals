using System;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthGraph = '|' + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) +'|';
            string energyGraph = '|'+ new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) +'|';

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.WriteLine(healthGraph);
            Console.Write("Energy: ");
            Console.WriteLine(energyGraph);
        }
    }
}
