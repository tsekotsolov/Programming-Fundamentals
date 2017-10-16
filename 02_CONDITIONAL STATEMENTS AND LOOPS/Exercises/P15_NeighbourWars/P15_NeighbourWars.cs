using System;
namespace P15_NeighbourWars
{
    class P15_NeighbourWars
    {
        static void Main()
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int attackCounter = 0;

            bool isAnyoneAlive = true;
            string attackName = string.Empty;
            string attacker = string.Empty;
            string attacked = string.Empty;
            int attackedHealth = 0;


            while (isAnyoneAlive)
            {
                attackCounter++;
                if (attackCounter % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    attackName = "Roundhouse kick";
                    attacker = "Pesho";
                    attacked = "Gosho";
                    attackedHealth = goshosHealth;
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    attackName = "Thunderous fist";
                    attacker = "Gosho";
                    attacked = "Pesho";
                    attackedHealth = peshosHealth;
                }
                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {attackCounter}th round.");
                    isAnyoneAlive = false;
                }
                else
                {
                    if (attackCounter % 3 == 0)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                    }
                    Console.WriteLine($"{attacker} used {attackName} and reduced {attacked} to {attackedHealth} health.");
                }
            }
        }
    }

}
 
