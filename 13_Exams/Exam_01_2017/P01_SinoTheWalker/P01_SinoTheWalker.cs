﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P01_SinoTheWalker
{
    class P01_SinoTheWalker
    {
        static void Main()
        {
            DateTime timeOfLeavingSoftUni = DateTime.Parse(Console.ReadLine());
            //int step = int.Parse(Console.ReadLine()) % 86400;
            //int seconds = int.Parse(Console.ReadLine()) % 86400;
            //86400 секунди = 1 ден
            //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход

            int stepsTaken = int.Parse(Console.ReadLine()) % 86400;
            int stepsPerSec = int.Parse(Console.ReadLine()) % 86400;
            int timeInTravel = stepsTaken * stepsPerSec;
            DateTime result = timeOfLeavingSoftUni.AddSeconds(timeInTravel);
          
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);

        }
    }
}
