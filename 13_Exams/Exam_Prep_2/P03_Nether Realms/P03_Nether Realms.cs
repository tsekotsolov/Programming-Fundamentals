using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03_Nether_Realms
{
    class Program
    {

        class Deamon
        {
            public int Health { get; set; }
            public double Damage { get; set; }
        }
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var healthStorage = new SortedDictionary<string, int>();
            var damageStorage = new SortedDictionary<string, double>();

            var bookOfEvil = new SortedDictionary<string, Deamon>();

            for (int i = 0; i < input.Length; i++)
            {

                var name = input[i];
                var totalHealth = GetHealth(input, i);
                var totalDamage = GetDamage(input, i);

                Deamon deamon = new Deamon();

                deamon.Health = totalHealth;
                deamon.Damage = totalDamage;

                if (!bookOfEvil.ContainsKey(input[i]))
                {
                    bookOfEvil.Add(input[i], deamon);
                }

                else
                {
                    bookOfEvil[name].Health += totalHealth;
                    bookOfEvil[name].Damage += totalDamage;
                }

            }

            foreach (var dzver in bookOfEvil)
            {
                Console.WriteLine($"{dzver.Key} - {dzver.Value.Health} health, {dzver.Value.Damage:f2} damage");
            }

        }

        private static double GetDamage(string[] input, int i)
        {
            var damagePattern = @"[+-]?[0-9]+[\.]?([0-9]+)?";

            var damage = Regex.Matches(input[i], damagePattern);

            var totalDamage = 0.0;

            foreach (Match number in damage)
            {
                totalDamage += double.Parse(number.ToString());
            }

            var mdPattern = @"[\*\/]";

            var mdMatch = Regex.Matches(input[i], mdPattern);

            foreach (Match literal in mdMatch)
            {
                if (literal.ToString()=="*")
                {
                    totalDamage*= 2.0;
                }

                else if (literal.ToString()==@"/")
                {
                    totalDamage/= 2.0;
                }
            }

            return totalDamage ;
        }

        private static int GetHealth(string[] input, int i)
        {
            var healthPattern = @"[^0-9\+\-\*\/\.]";
            var healthSymbols = Regex.Matches(input[i], healthPattern);
            var totalHealth = 0;

            foreach (Match item in healthSymbols)
            {
                var ch = item.Value.ToCharArray();

                totalHealth += ch[0];
            }

            return totalHealth;
        }

    }
}
