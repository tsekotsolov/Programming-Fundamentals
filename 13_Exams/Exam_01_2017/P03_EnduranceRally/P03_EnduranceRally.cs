using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_EnduranceRally
{
    class P03_EnduranceRally
    {
        static void Main()
        {
            var driversList = Console.ReadLine().Split().ToList();

            var track = Console.ReadLine().Split().Select(double.Parse).ToList();

            var checkPoint = Console.ReadLine().Split().Select(double.Parse).ToList();


            for (int i = 0; i < driversList.Count; i++)
            {

                var currentDriverFuel = (double)driversList[i].ToCharArray().First();

                for (int j = 0; j < track.Count; j++)
                {

                    if (!checkPoint.Contains(j))
                    {
                        currentDriverFuel -= track[j];


                        if (currentDriverFuel <= 0)
                        {
                            Console.WriteLine($"{driversList[i]} - reached {j}");
                            break;
                        }
                    }
                    else
                    {
                        currentDriverFuel += track[j];
                    }

                    if (j == track.Count - 1)
                    {
                        Console.WriteLine($"{driversList[i]} - fuel left {currentDriverFuel:f2}");
                        break;
                    }

                }
            }


        }
    }
}
