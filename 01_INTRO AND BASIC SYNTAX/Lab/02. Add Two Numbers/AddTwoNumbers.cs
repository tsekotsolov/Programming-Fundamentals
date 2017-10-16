using System;

namespace _02.Add_Two_Numbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)

        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");

        }
    }
}
