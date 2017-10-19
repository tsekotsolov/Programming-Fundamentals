using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Day_of_Week
{
    class Program
    {
        static void Main()
        {
          
            Console.WriteLine((DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture)).DayOfWeek);
        }
    }
}
