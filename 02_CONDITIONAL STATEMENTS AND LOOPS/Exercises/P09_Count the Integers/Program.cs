using System;
namespace P09_Count_the_Integers
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            while (true)
            {
                try
                {
                    var data = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch 
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
           
        }
    }
}
