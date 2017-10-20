using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Count_Working_Days
{
    class Program
    {
        static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];

            holidays[0] = DateTime.ParseExact("1-01-2016","d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[1] = DateTime.ParseExact("3-03-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[2] = DateTime.ParseExact("1-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[3] = DateTime.ParseExact("6-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[4] = DateTime.ParseExact("24-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[5] = DateTime.ParseExact("6-09-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[6] = DateTime.ParseExact("22-09-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[7] = DateTime.ParseExact("1-11-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[8] = DateTime.ParseExact("24-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[9] = DateTime.ParseExact("25-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[10] = DateTime.ParseExact("26-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);


            var workingDays = 0;
            

            for (DateTime i = firstDate; i <= secondDate; i=i.AddDays(1))
            {

                DateTime current = new DateTime(2016, i.Month, i.Day);
                var isWeekend = (i.DayOfWeek == DayOfWeek.Saturday)||(i.DayOfWeek==DayOfWeek.Sunday);

                if (!holidays.Contains(current) && !isWeekend)
                {
                    workingDays++;
                }


            }

            Console.WriteLine(workingDays);

        }
    }
}
