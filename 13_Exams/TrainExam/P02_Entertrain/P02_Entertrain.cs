using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Entertrain
{
    class P02_Entertrain
    {
        static void Main()
        {
            int nPower = int.Parse(Console.ReadLine());

            if (nPower == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var command = Console.ReadLine();

            var wagonsList = new List<int>();
            var sum = 0;

            while (command != "All ofboard!")
            {
                if (command != "All ofboard!")
                {
                    var wagonWeight = int.Parse(command);
                    wagonsList.Add(wagonWeight);
                    sum = wagonsList.Sum();
                    if (sum > nPower)
                    {
                        var average = sum / wagonsList.Count;

                        var closestNumber = average;
                        var closestDiff = int.MaxValue;

                        foreach (var item in wagonsList)
                        {

                            var currentDiff = Math.Abs(item - average);
                            if (currentDiff < closestDiff)
                            {
                                closestNumber = item;
                                closestDiff = currentDiff;
                            }

                        }

                        wagonsList.RemoveAll(x => x == closestNumber);

                    }

                }

                command = Console.ReadLine();
            }

            wagonsList.Reverse();
            wagonsList.Add(nPower);

            Console.WriteLine(string.Join(" ", wagonsList));

        }
    }
}
