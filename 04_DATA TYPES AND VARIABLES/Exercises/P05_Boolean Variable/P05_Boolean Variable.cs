using System;


namespace P05_Boolean_Variable
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();


            bool isTrue = Convert.ToBoolean(input);
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
