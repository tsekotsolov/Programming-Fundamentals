using System;


namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string state =Console.ReadLine().ToLower();

            if (state== "usa" || state=="england")
            {
                Console.WriteLine("English");
            }

            else if (state == "spain" || state == "argentina" || state == "mexico")
            {
                Console.WriteLine("Spanish");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
