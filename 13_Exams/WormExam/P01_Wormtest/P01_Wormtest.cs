using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Wormtest
{
    class P01_Wormtest
    {
        static void Main()
        {
            long lenght = long.Parse(Console.ReadLine()) * 100;

            double width = double.Parse(Console.ReadLine());

            if (lenght % width == 0 || width == 0)
            {
                Console.WriteLine($"{lenght*width:f2}");
            }

            else
            {
                Console.WriteLine($"{lenght/width*100:f2}%");
            }
        }
    }
}
